using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUsbDotNet;
using LibUsbDotNet.Main;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;
using System.IO.Ports;
using DevExpress.Internal.WinApi;
using DevExpress.XtraGauges.Win.Gauges.Circular;
using System.Threading;

namespace TempHumi
{ //khu vực tiền xử lý
    public partial class Form1 : Form
    {
        public static UsbDevice MyUsbDevice;  //khởi tạo giao tiếp usb
        public static UsbDeviceFinder MyUsbFinder = new UsbDeviceFinder(1155, 22370);
        UsbEndpointReader reader;
        UsbEndpointWriter writer;

        Excel.Application xlApp;   //khởi tạo excel
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        //public string folder_path = Environment.CurrentDirectory + @"\Data_TempHumi\";
        List<Hc> lstHc = new List<Hc>();
        DateTime g_dtTime;
        int g_Temp, g_Humi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_connect.Text = "Kết nối";
        }

        bool is_connected = false;
        private void bt_connect_Click(object sender, EventArgs e)
        {
            if (bt_connect.Text == "Kết nối") //kết nối
            {
                try
                {
                    MyUsbDevice = UsbDevice.OpenUsbDevice(MyUsbFinder);
                    if (MyUsbDevice == null) throw new Exception("Device Not Found.");
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        wholeUsbDevice.SetConfiguration(1);
                        wholeUsbDevice.ClaimInterface(0);
                    }
                    reader = MyUsbDevice.OpenEndpointReader(ReadEndpointID.Ep01);
                    writer = MyUsbDevice.OpenEndpointWriter(WriteEndpointID.Ep01);
                    reader.DataReceived += (OnRxEndPointData);
                    reader.DataReceivedEnabled = true;
                    bt_connect.Text = "Ngắt kết nối";
                is_connected = true;
                }
                catch
                {
                    MessageBox.Show("Không thể kết nối","Lỗi");
                }
            }
            else // ngắt kết nối
            {
                reader.DataReceivedEnabled = false;
                reader.DataReceived -= (OnRxEndPointData);
                reader.Dispose();
                writer.Dispose();
                if (MyUsbDevice != null)
                {
                    if (MyUsbDevice.IsOpen)
                    {
                        IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                        if (!ReferenceEquals(wholeUsbDevice, null))
                        {
                            wholeUsbDevice.ReleaseInterface(0);
                        }
                        MyUsbDevice.Close();

                    }
                    MyUsbDevice = null;
                    UsbDevice.Exit();
                }
                bt_connect.Text = "Kết nối";
                is_connected = false;
            }
        }
        private void OnRxEndPointData(object sender, EndpointDataEventArgs e)
        {
            //MessageBox.Show("ok");
            Action<string> Action = addToTextBox;
            this.BeginInvoke(Action, (Encoding.Default.GetString(e.Buffer, 0, e.Count)));
            
        }
       
        string temp, humi;
        private void addToTextBox(string input)
        {
            lb_temp.Text = "";
            lb_temp.Text += input.Substring(1,2);
            temp = lb_temp.Text.ToString();
            
            lb_humi.Text = "";
            lb_humi.Text = input.Substring(5,2);
            humi = lb_humi.Text.ToString();

            textBox1.Text += input.ToString();
        }

        private void bt_show_info_Click(object sender, EventArgs e)
        {
            FormInfo f = new FormInfo();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
        }

        //---------------------------------------------------------------------------------------------------------------- Excel
        private void merge_cell(Excel.Worksheet xlWorkSheet, int fromRow, int fromColumn, int toRow, int toColumn)
        {
            Excel.Range c1 = xlWorkSheet.Cells[fromRow, fromColumn];
            Excel.Range c2 = xlWorkSheet.Cells[toRow, toColumn];
            xlWorkSheet.get_Range(c1, c2).Merge();
        }
        private void export_excel()   //xuất dữ liệu ra excel
        {
            g_dtTime = DateTime.Now;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.ActiveSheet;

            //vẽ form
            merge_cell(xlWorkSheet, 1, 1, 1, 4);
            xlWorkSheet.Cells[1, 1] = "THỐNG KÊ NHIỆT ĐỘ VÀ ĐỘ ẨM";
            xlWorkSheet.Cells[1, 1].Font.Size = 12;
            xlWorkSheet.Cells[1, 1].Font.Bold = true;
            xlWorkSheet.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[1, 1].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

            xlWorkSheet.Cells[1].ColumnWidth = 3;
            xlWorkSheet.Cells[2].ColumnWidth = 20;
            xlWorkSheet.Cells[2, 1] = "STT";
            xlWorkSheet.Cells[2, 2] = "Thời gian";
            xlWorkSheet.Cells[2, 3] = "Nhiệt độ";
            xlWorkSheet.Cells[2, 4] = "Độ ẩm";

            write_data();
        }

        private void save_data()
        {
            object misValue = System.Reflection.Missing.Value;
            try
            {
                string path;
                string directoryPath = @"C:\Data_Temp_Humi\";   //đường dẫn lưu
                DirectoryInfo directory = new DirectoryInfo(directoryPath);
                if (!directory.Exists)
                {
                    directory.Create();
                }

                path = directoryPath + @" TempHumi" + "-" + g_dtTime.ToString("yyyyMMdd-HHmmss") + ".xls";
                xlWorkBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
                MessageBox.Show("Đã xuất file Excel", "Thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Không xuất được file Excel", "Lỗi");
            }

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void write_data()
        {
            int temp_Int = int.Parse(temp);
            int humi_Int = int.Parse(humi);
            g_Temp = temp_Int; g_Humi = humi_Int;
            Hc hc2 = new Hc(g_dtTime, g_Temp, g_Humi);
            lstHc.Add(hc2);
            for (int i = 0; i < lstHc.Count; i++)
            {
                xlWorkSheet.Cells[3+i, 1] = i+1;
                xlWorkSheet.Cells[3 + i, 2] = lstHc[i].m_dtTime;
                xlWorkSheet.Cells[3 + i, 3] = lstHc[i].m_Temp;
                xlWorkSheet.Cells[3 + i, 4] = lstHc[i].m_Humi;
            }
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (is_connected == true)
            {
                export_excel();
            }
        }
        private void send_data()
        {
            if (is_connected == true)
            {
                try
                {
                    int bytesWritten;
                    writer.Write(Encoding.Default.GetBytes("\x02" + 'A'), 1000, out bytesWritten);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Không truyền được dữ liệu USB\nDetails: " + err);
                }
            }
        }

        int max_temp_set, max_humi_set, temp_real, humi_real;

        private void set_value()
        {
            if (is_connected == true && lb_humi.Text != null && lb_temp.Text !=null)
            {
                try
                {
                    max_temp_set = int.Parse(max_temp.Value.ToString());
                    max_humi_set = int.Parse(max_rh.Value.ToString());
                    temp_real = int.Parse(lb_temp.Text.ToString());
                    humi_real = int.Parse(lb_humi.Text.ToString());

                    arcScaleComponent1.Value = temp_real;
                    linearScaleComponent1.Value = humi_real;
                }
                catch { }

                if (humi_real >= max_humi_set)
                {
                    try
                    {
                        int bytesWritten;
                        writer.Write(Encoding.Default.GetBytes("\x02" + 'B'), 100, out bytesWritten);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Không truyền được dữ liệu USB\nDetails: " + err);
                    }
                }
                else if (humi_real < max_humi_set)
                {
                    try
                    {
                        int bytesWritten;
                        writer.Write(Encoding.Default.GetBytes("\x02" + 'b'), 100, out bytesWritten);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Không truyền được dữ liệu USB\nDetails: " + err);
                    }
                }
                if (temp_real >= max_temp_set)
                {
                    try
                    {
                        int bytesWritten;
                        writer.Write(Encoding.Default.GetBytes("\x02" + 'A'), 100, out bytesWritten);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Không truyền được dữ liệu USB\nDetails: " + err);
                    }
                }
                
                else if (temp_real < max_temp_set)
                {
                    try
                    {
                        int bytesWritten;
                        writer.Write(Encoding.Default.GetBytes("\x02" + 'a'), 100, out bytesWritten);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Không truyền được dữ liệu USB\nDetails: " + err);
                    }
                }
                
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            set_value();
        }
        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_data();
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
