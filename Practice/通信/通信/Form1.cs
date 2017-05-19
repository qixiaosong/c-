using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace 通信
{
    public partial class Form1 : Form
    {
        int flag = 1;
        int Send_Pointer = 0;            //Send_Pointer用于控制发送缓存的相对偏移地址
        Byte[] SenDataBuf_Hex = new Byte[1024];    //发送缓冲区
        Byte[] RecDataBuf_Hex = new Byte[1024];    //接收缓冲区

        string RecDataBuf_Str = "";
        
        int LengthOfSend = 0;   //待发送的字节长度              
        int LengthOfRece = 0;   //接收到的字节长度

        private SerialPort MySerialPort = new SerialPort();
        public delegate void newDelegat();

        private void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            #region 串口触发事件处理
            try
            {
                LengthOfRece = MySerialPort.BytesToRead;
                if (LengthOfRece > 0)
                {
                    MySerialPort.Read(RecDataBuf_Hex, 0, LengthOfRece);      //从缓冲区读取一个字节数据
                    for (int i = 0; i < LengthOfRece; i++)
                    {
                        RecDataBuf_Str += String.Format("{0:X2}", RecDataBuf_Hex[i]) + " ";

                    }
                   
                    this.BeginInvoke(new newDelegat(UpdateReceTextBox)); //异步执行委托,更新显示面板
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误如下:\n" + ex.ToString(), "友情提示!", MessageBoxButtons.OK);
            }
            finally
            {
                MySerialPort.ReceivedBytesThreshold = 1;
            }
            #endregion
        }



        /// <summary>
        /// 更新参数
        /// </summary>
        public void UpdateReceTextBox()
        {
            #region 更新控件

            try
            {
                
                int start = 7, length =2;
                
                if (flag == 1)
                {
                    RecDataBuf_Str = RecDataBuf_Str.Substring(start - 1, length);
                }
                if (RecDataBuf_Str == "06")
                {
                    MessageBox.Show("无卡");
                }
                if (RecDataBuf_Str == "08")
                {
                    flag = 0;
                    SendTxtBuf2();
                    
                }
                if ((RecDataBuf_Str != "08")&(flag == 0))
               {
                    flag = 1;
                   RecDataBuf_Str = RecDataBuf_Str.Substring(27, 11);
                    textBox2.AppendText(RecDataBuf_Str);     //更新接收面板,显示具体接收到的字节数据
                    textBox2.ScrollToCaret();
               }
                
               
            }
            catch (Exception err)
            {
                MessageBox.Show("错误如下:\n" + err.Message, "友情提示!", MessageBoxButtons.OK);
            }
            finally
            {
                RecDataBuf_Str = "";
               
            }
            #endregion   
        }
        public Form1()
        {
            InitializeComponent();
            this.MySerialPort.ReceivedBytesThreshold = 1; //设定几个字节触发一次
            this.MySerialPort.ReadBufferSize = 1024;       //缓存大小为1024
            this.MySerialPort.WriteBufferSize = 1024;
            this.MySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceived);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                //第二步:串口设定
                string[] portName = System.IO.Ports.SerialPort.GetPortNames();


                for (int i = 0; i <= portName.Length - 1; i++)
                {
                    cbbCOMPorts.Items.Add(portName[i]);
                }

                cbbCOMPorts.SelectedIndex = 0;



                //第三步:波特率设定，默认是9600
                string[] baudRate ={"300",
                                "600",
                                "1200",
                                "2400",
                                "4800",
                                "9600",
                                "19200",
                                "38400",
                                "43000",
                                "56000",
                                "57600",
                                "115200"};
                for (int a = 0; a < baudRate.Length; a++)
                {
                    cbbbaudrate.Items.Add(baudRate[a]);
                }
                cbbbaudrate.SelectedIndex = 6;
                //第四步:数据位设定,默认选择8位数据
                string[] DataBits ={"5",
                                    "6",
                                    "7",
                                    "8"
                                    };
                for (int a = 0; a < DataBits.Length; a++)
                {
                    cbbdatabits.Items.Add(DataBits[a]);
                }
                cbbdatabits.SelectedIndex = 3;


                //第五步:停止位设定,默认是一位
                string[] StopBits ={"1",
                                    "2"
                                    };
                for (int a = 0; a < StopBits.Length; a++)
                {
                    cbbstopbits.Items.Add(StopBits[a]);
                }
                cbbstopbits.SelectedIndex = 0;


                //第六步:校验位设定
                string[] CheckOutBit = { "NONE", "ODD", "EVEN" };
                for (int a = 0; a < CheckOutBit.Length; a++)
                {
                    cbbcheckoutbit.Items.Add(CheckOutBit[a]);
                }
                cbbcheckoutbit.SelectedIndex = 0;





                button1.Text = "打开串口";
                btnUnvisible.Text = "connect";

            }
            catch (Exception error)
            {
                MessageBox.Show("错误如下:\n" + error.ToString(), "友情提示!", MessageBoxButtons.OK);
            }
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnUnvisible.Text == "connect")     //连接
            {
                timer1.Interval = 1;                //每隔8ms发送一个字节
                //before you click the button of "Connect",close all ports opened.
                if (MySerialPort.IsOpen)
                {
                    MySerialPort.Close();
                }
                try
                {
                    //对串口参数的配置
                    MySerialPort.PortName = cbbCOMPorts.Text;              //加载端口号
                    MySerialPort.BaudRate = int.Parse(cbbbaudrate.Text);   //设置波特率

                    //数据位的确定
                    switch (cbbdatabits.Text)
                    {
                        case "5": MySerialPort.DataBits = 5; break;
                        case "6": MySerialPort.DataBits = 6; break;
                        case "7": MySerialPort.DataBits = 7; break;
                        default: MySerialPort.DataBits = 8; break;
                    }

                    //停止位的确定
                    switch (cbbstopbits.Text)
                    {
                        case "2": MySerialPort.StopBits = System.IO.Ports.StopBits.Two; break;
                        default: MySerialPort.StopBits = System.IO.Ports.StopBits.One; break;
                    }

                    //校验方式的确定
                    switch (cbbcheckoutbit.Text)
                    {
                        case "ODD": MySerialPort.Parity = System.IO.Ports.Parity.Odd; break;
                        case "EVEN": MySerialPort.Parity = System.IO.Ports.Parity.Even; break;
                        default: MySerialPort.Parity = System.IO.Ports.Parity.None; break;
                    }

                    //编码的确定
                    MySerialPort.Encoding = Encoding.ASCII;
                    //打开已经配置好的串口
                    MySerialPort.Open();

                    //**************************************************************************************
                    //**************************************************************************************


                    //设置串口参数不可用
                    cbbCOMPorts.Enabled = false;
                    cbbbaudrate.Enabled = false;
                    cbbdatabits.Enabled = false;
                    cbbstopbits.Enabled = false;
                    cbbcheckoutbit.Enabled = false;

                    button1.Text = "关闭串口";
                    btnUnvisible.Text = "dispose";


                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误如下:\n" + ex.Message, "友情提示!", MessageBoxButtons.OK);
                }
            }
            else //释放
            {
                try
                {
                    timer1.Stop();
                    MySerialPort.Close();
                    labelMssage.Text = MySerialPort.PortName + " disconnected now";//释放当前连接的端口

                    cbbCOMPorts.Enabled = true;
                    cbbbaudrate.Enabled = true;
                    cbbdatabits.Enabled = true;
                    cbbstopbits.Enabled = true;
                    cbbcheckoutbit.Enabled = true;

                    button1.Text = "打开串口";
                    btnUnvisible.Text = "connect";
                }
                catch (Exception error)
                {
                    MessageBox.Show("错误如下:\n" + error.Message, "友情提示!", MessageBoxButtons.OK);
                }

            }
        }
        public void SendTxtBuf1()
        {
            try
            {
                if (button1.Text != "打开串口")
                {
                        String xunka = "AABB 0600 0000 0102 5251";
                        string HexString = xunka.Trim().Replace(" ", "");　//将AA 55 A5 5A转换成AA55A55A
                        if (HexString.Length % 2 == 0)              //仅仅偶数时才处理
                        {
                            LengthOfSend = HexString.Length / 2;    //要发送的字节数
                            for (int i = 0; i < LengthOfSend; i++)  //字节数组的长度
                            {
                                SenDataBuf_Hex[i] = Convert.ToByte(HexString.Substring(i * 2, 2), 16);//{0xAA,0x55,0xA5,0x5A}
                            }
                            if (timer1.Enabled == false)            //时间空闲时才启动
                            {
                                Send_Pointer = 0;
                                timer1.Start();
                            }
                        }
                    
                   
                }
                else
                {
#if DEBUG_MSG
                        MessageBox.Show("错误如下：\n" + "串口未打开!" + "\n", "友情提示!", MessageBoxButtons.OK); 
#else
                    MessageBox.Show("错误如下：\n" + "串口未打开!" + "\n", "友情提示!", MessageBoxButtons.OK);
#endif
                }
            }
            catch (Exception error)
            {
#if DEBUG_MSG
                MessageBox.Show("错误如下：\n" + error.ToString()  + "\n", "友情提示!", MessageBoxButtons.OK); 
#else
                MessageBox.Show("错误如下：\n" + error.Message + "\n", "友情提示!", MessageBoxButtons.OK);
#endif


            }
        }

        public void SendTxtBuf2()
        {
            try
            {
                if (button1.Text != "打开串口")
                {
                    String xunka = "AABB 0600 0000 0202 0404";
                    string HexString = xunka.Trim().Replace(" ", ""); //将AA 55 A5 5A转换成AA55A55A
                    if (HexString.Length % 2 == 0)              //仅仅偶数时才处理
                    {
                        LengthOfSend = HexString.Length / 2;    //要发送的字节数
                        for (int i = 0; i < LengthOfSend; i++)  //字节数组的长度
                        {
                            SenDataBuf_Hex[i] = Convert.ToByte(HexString.Substring(i * 2, 2), 16);//{0xAA,0x55,0xA5,0x5A}
                        }
                        if (timer1.Enabled == false)            //时间空闲时才启动
                        {
                            Send_Pointer = 0;
                            timer1.Start();
                        }
                    }


                }
                else
                {
#if DEBUG_MSG
                        MessageBox.Show("错误如下：\n" + "串口未打开!" + "\n", "友情提示!", MessageBoxButtons.OK); 
#else
                    MessageBox.Show("错误如下：\n" + "串口未打开!" + "\n", "友情提示!", MessageBoxButtons.OK);
#endif
                }
            }
            catch (Exception error)
            {
#if DEBUG_MSG
                MessageBox.Show("错误如下：\n" + error.ToString()  + "\n", "友情提示!", MessageBoxButtons.OK); 
#else
                MessageBox.Show("错误如下：\n" + error.Message + "\n", "友情提示!", MessageBoxButtons.OK);
#endif


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SendTxtBuf1();
        }

       
private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {


                MySerialPort.Write(SenDataBuf_Hex, Send_Pointer, 1);//将要发送的数据写到port   0 1  
               
                if (Send_Pointer > LengthOfSend - 2)   //相应的单个字节处理 10-1=9
                {
                    LengthOfSend = 0;
                    Send_Pointer = 0; //置回偏移地址
                    timer1.Stop();
                }
                Send_Pointer++;
            }
            catch  //(Exception error)
            {
                Send_Pointer = 0;
                LengthOfSend = 0;
                timer1.Stop();
#if DEBUG_MSG
                MessageBox.Show("错误如下：\n" + error.ToString() + "\n", "友情提示!", MessageBoxButtons.OK);
#else
                //MessageBox.Show("错误如下：\n" + error.Message + "\n", "友情提示!", MessageBoxButtons.OK);
#endif 
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //SendTxtBuf();//一次发送发送区域的内容.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

