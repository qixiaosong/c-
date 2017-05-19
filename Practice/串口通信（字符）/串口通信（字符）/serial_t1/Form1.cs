using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Ports;

namespace serial_t1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    //串口设置
                    serialPort1.PortName = cbSerial.SelectedItem.ToString(); //串口号
                    serialPort1.BaudRate = Convert.ToInt32(cbBaudRate.Text); //波特率
                    serialPort1.DataBits = Convert.ToInt32(cbDataBits.Text); //数据位
                    switch (cbStop.Text)
                    {
                        case "1":
                            serialPort1.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("Error:参数不正确!", "Error");
                            break;
                    }

                    switch (cbParity.Text)             //校验位
                    {
                        case "无":
                            serialPort1.Parity = Parity.None;
                            break;
                        case "奇校验":
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case "偶校验":
                            serialPort1.Parity = Parity.Even;
                            break;
                        default:
                            MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }

                    serialPort1.Open();
                    btnSwitch.Text = "关闭串口";

                }
            
                catch(System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    return;
                }
            }
            else
            {
                serialPort1.Close();
                btnSwitch.Text = "打开串口";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //检查是否含有串口
            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                MessageBox.Show("本机没有串口！", "Error");
                return;  
            }

            //添加串口项目
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {//获取有多少个COM口
                //System.Diagnostics.Debug.WriteLine(s);
                cbSerial.Items.Add(s);
            }
            //串口设置默认选择项  
            cbSerial.SelectedIndex = 0;         //设置cbSerial的默认选项  

            //添加波特率
            cbBaudRate.Items.Add("300");
            cbBaudRate.Items.Add("600");
            cbBaudRate.Items.Add("1200");
            cbBaudRate.Items.Add("2400");
            cbBaudRate.Items.Add("4800");
            cbBaudRate.Items.Add("9600");
            cbBaudRate.Items.Add("19200");
            cbBaudRate.Items.Add("38400");
            cbBaudRate.Items.Add("115200");
            cbBaudRate.Items.Add("128000");
            cbBaudRate.Items.Add("256000");
            cbBaudRate.SelectedIndex = 5;  //设置cbBaudRate的默认选项  

            //添加校验位
            cbParity.Items.Add("无");
            cbParity.Items.Add("奇校验");
            cbParity.Items.Add("偶校验");
            cbParity.SelectedIndex = 0;

            //添加数据位
            cbDataBits.Items.Add("5");
            cbDataBits.Items.Add("6");
            cbDataBits.Items.Add("7");
            cbDataBits.Items.Add("8");
            cbDataBits.SelectedIndex = 3;

            //添加停止位
            cbStop.Items.Add("1");
            cbStop.Items.Add("1.5");
            cbStop.Items.Add("2");
            cbStop.SelectedIndex = 0;
  

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = txtSend.Text;
            serialPort1.Write(str);   //发送数据到串口
            
        }


        //清空按钮
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRec.Text = "";    //清空文本
        }

        //串口接收
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           string RecieveData = "";
           char[] data = new char[serialPort1.BytesToRead];
           serialPort1.Read(data,0,data.Length);  //读取串口数据
           for(int i=0;i<data.Length;i++)
           {
               RecieveData += data[i];
           }
            //委托
           txtRec.Invoke(new Action(()=>              //不懂
               {
                   txtRec.AppendText(RecieveData);
               }
               )
               );

        }

        private void txtRec_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSend_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
