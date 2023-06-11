#include "main.h"
#include "usb_device.h"
#include "usbd_customhid.h"
#include "stdio.h"
#include "stdbool.h"
#include "math.h"
#include "DHT.h"
#include <string.h>
#include "dwt_stm32_delay.h"

uint8_t is_test = 0;
DHT_Name DHT1;

TIM_HandleTypeDef htim2;
TIM_HandleTypeDef htim4;

void delay_us (uint16_t us)
{
    __HAL_TIM_SET_COUNTER(&htim2,0);  // set the counter value a 0
    while (__HAL_TIM_GET_COUNTER(&htim2) < us);  // wait for the counter to reach the us input in the parameter
}
void delay_ms(uint16_t ms)
{
    for(int i=0;i<ms;i++)
    {
        delay_us(1000);
    }
}

//--------------------------------dht22
uint8_t Rh_byte1, Rh_byte2, Temp_byte1, Temp_byte2;
uint16_t SUM, RH, TEMP;
	
float temp_Celsius = 0;

float Temperature = 0;
float Humidity = 0;
uint8_t Presence = 0;

#define DHT22_PORT GPIOB
#define DHT22_PIN GPIO_PIN_14

void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_TIM2_Init(void);
static void MX_TIM4_Init(void);

uint8_t USB_TX_Buffer[65];
uint8_t USB_TX_Buffer_Test[65] = "Z";
	
char uintValue_rh;
char uintValue_temp;
	
void send_data()
{
    uintValue_temp = (uint8_t)round(temp_Celsius);
    uintValue_rh = (uint8_t)round(Humidity);
    sprintf((char *)USB_TX_Buffer,"T%i H%i\r\n",uintValue_temp,uintValue_rh);
    USBD_CUSTOM_HID_SendReport(&hUsbDeviceFS,USB_TX_Buffer,65);
    delay_ms(100);
}

void HAL_TIM_PeriodElapsedCallback(TIM_HandleTypeDef *htim)
{
  if (htim->Instance == TIM2)
  {
    
  }
	if (htim->Instance == TIM4)
  {
   
  }
}

uint8_t hum1, hum2, tempC1, tempC2, CHECK;
uint32_t pMillis, cMillis;

float temp_Fahrenheit = 0;
uint8_t hum_integral, hum_decimal, tempC_integral, tempC_decimal, tempF_integral, tempF_decimal;
char string[15];

uint8_t DHT22_Start1 (void)
{
    uint8_t Response = 0;
    GPIO_InitTypeDef GPIO_InitStructPrivate = {0};
    GPIO_InitStructPrivate.Pin = DHT22_PIN;
    GPIO_InitStructPrivate.Mode = GPIO_MODE_OUTPUT_PP;
    GPIO_InitStructPrivate.Speed = GPIO_SPEED_FREQ_LOW;
    GPIO_InitStructPrivate.Pull = GPIO_NOPULL;
    HAL_GPIO_Init(DHT22_PORT, &GPIO_InitStructPrivate); 
    HAL_GPIO_WritePin (DHT22_PORT, DHT22_PIN, 0);   
    DWT_Delay_us (1300);   
    HAL_GPIO_WritePin (DHT22_PORT, DHT22_PIN, 1);  
    DWT_Delay_us (30);   
    GPIO_InitStructPrivate.Mode = GPIO_MODE_INPUT;
    GPIO_InitStructPrivate.Pull = GPIO_PULLUP;
    HAL_GPIO_Init(DHT22_PORT, &GPIO_InitStructPrivate); 
    DWT_Delay_us (40);
    if (!(HAL_GPIO_ReadPin (DHT22_PORT, DHT22_PIN)))
    {
        DWT_Delay_us (80);
        if ((HAL_GPIO_ReadPin (DHT22_PORT, DHT22_PIN))) 
            Response = 1;
    }
    pMillis = HAL_GetTick();
    cMillis = HAL_GetTick();
    while ((HAL_GPIO_ReadPin (DHT22_PORT, DHT22_PIN)) && pMillis + 2 > cMillis)
    {
        cMillis = HAL_GetTick();
    }
    return Response;
}

uint8_t DHT22_Read1 (void)
{
    uint8_t x,y;
    for (x=0;x<8;x++)
    {
        pMillis = HAL_GetTick();
        cMillis = HAL_GetTick();
        while (!(HAL_GPIO_ReadPin (DHT22_PORT, DHT22_PIN)) && pMillis + 2 > cMillis)
        {  
            cMillis = HAL_GetTick();
        }
        DWT_Delay_us (40);  
        if (!(HAL_GPIO_ReadPin (DHT22_PORT, DHT22_PIN)))   // if the pin is low
            y&= ~(1<<(7-x));
        else
            y|= (1<<(7-x));
        pMillis = HAL_GetTick();
        cMillis = HAL_GetTick();
        while ((HAL_GPIO_ReadPin (DHT22_PORT, DHT22_PIN)) && pMillis + 2 > cMillis)
        {  // wait for the pin to go low
            cMillis = HAL_GetTick();
        }
    }
    return y;
}

void HAL_GPIO_EXTI_Callback(uint16_t GPIO_Pin)     //nút nhan test
{
    if (GPIO_Pin == BUTTON_Pin)
    {
        is_test = 1;
    }
}

int main(void)
{
    HAL_Init();
    SystemClock_Config();

    MX_GPIO_Init();
    MX_USB_DEVICE_Init();
    MX_TIM2_Init();
    MX_TIM4_Init();

	DWT_Delay_Init();
    HAL_TIM_Base_Start_IT(&htim4);
    HAL_TIM_Base_Start_IT(&htim2);

	HAL_GPIO_WritePin(SPK_GPIO_Port,SPK_Pin,1);
	HAL_Delay(300);
	HAL_GPIO_WritePin(SPK_GPIO_Port,SPK_Pin,0);
    
    while (1)
    {
        HAL_GPIO_TogglePin(LED_GPIO_Port,LED_Pin);
		
		if(DHT22_Start1())
	    {
            hum1 = DHT22_Read1(); 
            hum2 = DHT22_Read1();
            tempC1 = DHT22_Read1(); 
            tempC2 = DHT22_Read1(); 
            SUM = DHT22_Read1(); 
            CHECK = hum1 + hum2 + tempC1 + tempC2;
            if (CHECK == SUM)
            {
                if (tempC1>127) 
                {
                    temp_Celsius = (float)tempC2/10*(-1);
                }
                else
                {
                    temp_Celsius = (float)((tempC1<<8)|tempC2)/10;
                }

                Humidity = (float) ((hum1<<8)|hum2)/10;
                     
                send_data(); 
            }
        }
	    
        HAL_Delay(2000);
  
        if(is_test == 1)
        {
            for(int i=0;i<3;i++)
            {					 
                HAL_GPIO_WritePin(LED_GPIO_Port,LED_Pin,1);
                HAL_GPIO_WritePin(SPK_GPIO_Port,SPK_Pin,1);
                HAL_GPIO_WritePin(FAN_GPIO_Port,FAN_Pin,1);
                HAL_Delay(300);
                HAL_GPIO_WritePin(LED_GPIO_Port,LED_Pin,0);
                HAL_GPIO_WritePin(SPK_GPIO_Port,SPK_Pin,0);
                HAL_Delay(300);
            }
                HAL_GPIO_WritePin(FAN_GPIO_Port,FAN_Pin,0);

                is_test = 0;
        }
    }
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};
  RCC_PeriphCLKInitTypeDef PeriphClkInit = {0};

  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_ON;
  RCC_OscInitStruct.HSEPredivValue = RCC_HSE_PREDIV_DIV1;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
  RCC_OscInitStruct.PLL.PLLMUL = RCC_PLL_MUL9;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }

  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV2;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_2) != HAL_OK)
  {
    Error_Handler();
  }
  PeriphClkInit.PeriphClockSelection = RCC_PERIPHCLK_USB;
  PeriphClkInit.UsbClockSelection = RCC_USBCLKSOURCE_PLL_DIV1_5;
  if (HAL_RCCEx_PeriphCLKConfig(&PeriphClkInit) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief TIM2 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM2_Init(void)
{

  /* USER CODE BEGIN TIM2_Init 0 */

  /* USER CODE END TIM2_Init 0 */

  TIM_ClockConfigTypeDef sClockSourceConfig = {0};
  TIM_MasterConfigTypeDef sMasterConfig = {0};

  /* USER CODE BEGIN TIM2_Init 1 */

  /* USER CODE END TIM2_Init 1 */
  htim2.Instance = TIM2;
	  htim2.Init.Prescaler = 72-1;
  htim2.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim2.Init.Period = 0xffff-1;
  
  htim2.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
  htim2.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  if (HAL_TIM_Base_Init(&htim2) != HAL_OK)
  {
    Error_Handler();
  }
  sClockSourceConfig.ClockSource = TIM_CLOCKSOURCE_INTERNAL;
  if (HAL_TIM_ConfigClockSource(&htim2, &sClockSourceConfig) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim2, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM2_Init 2 */

  /* USER CODE END TIM2_Init 2 */

}

/**
  * @brief TIM4 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM4_Init(void)
{

  /* USER CODE BEGIN TIM4_Init 0 */

  /* USER CODE END TIM4_Init 0 */

  TIM_ClockConfigTypeDef sClockSourceConfig = {0};
  TIM_MasterConfigTypeDef sMasterConfig = {0};

  /* USER CODE BEGIN TIM4_Init 1 */

  /* USER CODE END TIM4_Init 1 */
  htim4.Instance = TIM4;
	htim4.Init.Prescaler = 36000;
  htim4.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim4.Init.Period = 4000 - 1;
  htim4.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
  htim4.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  if (HAL_TIM_Base_Init(&htim4) != HAL_OK)
  {
    Error_Handler();
  }
  sClockSourceConfig.ClockSource = TIM_CLOCKSOURCE_INTERNAL;
  if (HAL_TIM_ConfigClockSource(&htim4, &sClockSourceConfig) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim4, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM4_Init 2 */

  /* USER CODE END TIM4_Init 2 */

}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{
  GPIO_InitTypeDef GPIO_InitStruct = {0};

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOD_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOA, GPIO_PIN_7|GPIO_PIN_10, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOB, GPIO_PIN_0|GPIO_PIN_14, GPIO_PIN_RESET);

  /*Configure GPIO pin : PA0 */
  GPIO_InitStruct.Pin = GPIO_PIN_0;
  GPIO_InitStruct.Mode = GPIO_MODE_IT_FALLING;
  GPIO_InitStruct.Pull = GPIO_PULLUP;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : PA7 PA10 */
  GPIO_InitStruct.Pin = GPIO_PIN_7|GPIO_PIN_10;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : PB0 PB14 */
  GPIO_InitStruct.Pin = GPIO_PIN_0|GPIO_PIN_14;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /* EXTI interrupt init*/
	
  HAL_NVIC_SetPriority(EXTI0_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(EXTI0_IRQn);


}

/* USER CODE BEGIN 4 */


/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */
