# TempHumi

Source code giao diện winform trong folder TempHumi

Source code vi điều khiển STM32F103C8T6 trong folder STM32_temphumi

Công nghệ sử dụng: Ngôn ngữ lập trinh C#/.NET để tạo giao diện winform và giao tiếp với vi điều khiển. Ngôn ngữ lập trình C để lập trình cho vi điều khiển nhận dữ liệu và điều khiển các thiết bị ngoại vi.

Chức năng: Vi điều khiển STM32F103C8T6 nhận dữ liệu từ cảm biến truyền tới phần mềm máy tính. Phần mềm máy tính lưu trữ, phân tích dữ liệu rồi truyền ký tự lệnh cho vi điều khiển vận hành các thiết bị ngoại vi.

Giao diện winform:
![image](https://github.com/tuandung1379/Collect-temperature-humidity/assets/92191400/2b9b935b-1a68-4a9c-b515-ec9eeda03987)

Các bước vận hành:
-	Bước 1: Cấp nguồn cho toàn mô hình hệ thống. Ta có thể cấp nguồn 220V AC hoặc sử dụng nguồn 5V DC từ USB B.
-	Bước 2: Khởi động phần mềm, giao diện hệ thống trông sẽ như hình minh hoạ: 
 ![image](https://github.com/tuandung1379/Collect-temperature-humidity/assets/92191400/852fe606-d640-4b6d-8b16-3b66ac03de9c)
-	Bước 3: Sử dụng tính năng trong phần mềm:

•	Kết nối cổng USB-B trên mô hình với cổng USB trên máy tính.

•	Nhấn kết nối, phần mềm và phần cứng sẽ được kết nối với nhau để 
trao đổi dữ liệu nếu kết nối thành công màn hình chữ kết nối sẽ chuyển thành ngắt kết nối. Lúc này phần mềm và phần cứng đã được kết nối với nhau sẵn sàng trao đổi dữ liệu. 

Lưu ý: Nếu dây chưa cắm hoặc có lỗi về cổng USB của mô hình hoặc máy tính thì sẽ có báo lỗi như ảnh dưới đây:
![image](https://github.com/tuandung1379/Collect-temperature-humidity/assets/92191400/86bf519b-312a-487e-ace4-b657cfba9158)

Màn hình chia làm 2 nửa phải và trái, phía bên trái sẽ hiển thị thông tin nhiệt độ dưới dạng số và dưới dạng kim. Phía bên phải màn hình hiển thị thông số độ ẩm dưới dạng số và dạng thang đo như hình dưới:
![image](https://github.com/tuandung1379/Collect-temperature-humidity/assets/92191400/ea87f7ba-70a0-47b3-a3ef-78b6731838af)

•	Ô nhập ngưỡng nhiệt độ: Người dùng nhập vào mức nhiệt độ mà nếu thiết bị đo được trong môi trường đợt tới mức nhiệt này hoặc cao hơn thì hệ thống sẽ phát còi báo hiệu cảnh báo.

•	Ô nhập ngưỡng độ ẩm: Tương tự như ngưỡng nhiệt độ, người dùng nhập vào mức độ ẩm mà nếu thiết bị phát hiện tới mức độ ẩm này hoặc cao hơn sẽ lập tức bật thiết bị quạt gắn với nó để làm giảm độ ẩm.

 ![image](https://github.com/tuandung1379/Collect-temperature-humidity/assets/92191400/9ce3cff0-a732-4e9d-a0cd-c6fd7b044b57)

- Nút “Save” trên thanh công cụ có chức năng xuất thông tin nhiệt độ và độ ẩm đo được kể từ khi khởi chạy hệ thống, xuất dữ liệu ra file Excel, đồng thời trên hiển thị thông báo trên màn hình dòng chữ “Đã xuất file Excel”.

 ![image](https://github.com/tuandung1379/Collect-temperature-humidity/assets/92191400/09f71189-7f33-4005-bd05-5780f149c47f)
- Sau đó truy cập đường dẫn C:\Data_Temp_Humi để xem kết quả được hiển thị trên file Excel




