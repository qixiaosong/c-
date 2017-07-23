using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;



namespace RS232
{
   
    public partial class fclsRS232Tester : Form
    {
        byte[] InputData = new byte[14];
        byte[] sendbuf1 = { 0xaa, 0xaa, 0x00, 0x03, 0xf1, 0x00 };
        byte[] sendbuf2 = { 0xaa, 0xaa, 0x00, 0x03, 0xf0, 0x00 };
        byte[] sendbuf3 = { 0xaa, 0xaa, 0x00, 0x03, 0xf2, 0x00 };
        String history = "";
        String history30 = "\r\n";
        String history29 = "\r\n";
        String history28 = "\r\n"; 
        String history27 = "\r\n";
        String history26 = "\r\n";
        String history25 = "\r\n";
        String history24 = "\r\n";
        String history23 = "\r\n";
        String history22 = "\r\n";
        String history21 = "\r\n";
        String history20 = "\r\n";
        String history19 = "\r\n";
        String history18 = "\r\n";
        String history17 = "\r\n";
        String history16 = "\r\n";
        String history15 = "\r\n";
        String history14 = "\r\n";
        String history13 = "\r\n";
        String history12 = "\r\n";
        String history11 = "\r\n";
        String history10 = "\r\n";
        String history9 = "\r\n";
        String history8 = "\r\n";
        String history7 = "\r\n";
        String history6 = "\r\n";
        String history5 = "\r\n";
        String history4 = "\r\n";
        String history3 = "\r\n";
        String history2 = "\r\n";
        String history1 = "\r\n";
        DateTime t1 = System.DateTime.Now;
        delegate void SetTextCallback(string text);
 
        public fclsRS232Tester()
        {
            InitializeComponent();

            // Nice methods to browse all available ports:
            string[] ports = SerialPort.GetPortNames();

            // Add all port names to the combo box:
            foreach (string port in ports)
            {
                cmbComSelect.Items.Add(port);
            }
        }

        private void cmbComSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (port.IsOpen) port.Close();
            port.PortName = cmbComSelect.SelectedItem.ToString();
            port.BaudRate = 115200;
            stsStatus.Text = port.PortName + ":9600,8N1";

            // try to open the selected port:
            try
            {
                port.Open();
            }
            // give a message, if the port is not available:
            catch
            {
                MessageBox.Show("Serial port " + port.PortName + " cannot be opened!", "RS232 tester", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbComSelect.SelectedText = "";
                stsStatus.Text = "Select serial port!";
            }
            port.Write(sendbuf2, 0, 6);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
                port.BaudRate = Convert.ToInt32(comboBox1.SelectedItem.ToString());
        }
        //private void btnSend_Click(object sender, EventArgs e)
        //{
        //    //if (port.IsOpen) port.WriteLine(txtOut.Text);
        //    //else MessageBox.Show("Serial port is closed!", "RS232 tester", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //txtOut.Clear();
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtIn.Clear();
        }
        //byte[] num = new byte[1];
        //DateTime t2;
        //TimeSpan ts;
        
 //       public TIME times=new TIME();
        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            //t2 = System.DateTime.Now;
            //ts = t1.Subtract(t2).Duration();

            InputData[0] = Convert.ToByte(port.ReadByte());
            InputData[1] = Convert.ToByte(port.ReadByte());
            InputData[2] = Convert.ToByte(port.ReadByte());
            InputData[3] = Convert.ToByte(port.ReadByte());
            InputData[4] = Convert.ToByte(port.ReadByte());
            InputData[5] = Convert.ToByte(port.ReadByte());
            InputData[6] = Convert.ToByte(port.ReadByte());
            InputData[7] = Convert.ToByte(port.ReadByte());
            InputData[8] = Convert.ToByte(port.ReadByte());
            InputData[9] = Convert.ToByte(port.ReadByte());
            InputData[10] = Convert.ToByte(port.ReadByte());
            InputData[11] = Convert.ToByte(port.ReadByte());
            InputData[12] = Convert.ToByte(port.ReadByte());
            InputData[13] = Convert.ToByte(port.ReadByte());

            //if (InputData[1] == 49)
            //{
            //    num[0] = 01;
                
            //}
            //if (InputData[1] == 50)
            //{
            //    num[0] = 02;
            //}
            //if (InputData[1] == 51)
            //{
            //    num[0] = 03;
            //}

            ShowMessage(InputData);
        }
        //public static void ByteArrayToStructure(byte[] bytearray, ref object obj, int startoffset)
        //{
        //    int len = Marshal.SizeOf(obj);
        //    IntPtr i = Marshal.AllocHGlobal(len);
        //    // 从结构体指针构造结构体
        //    obj = Marshal.PtrToStructure(i, obj.GetType());
        //    try
        //    {
        //        // 将字节数组复制到结构体指针
        //        Marshal.Copy(bytearray, startoffset, i, len);
        //    }
        //    catch (Exception ex) { Console.WriteLine("ByteArrayToStructure FAIL: error " + ex.ToString()); }
        //    obj = Marshal.PtrToStructure(i, obj.GetType());
        //    Marshal.FreeHGlobal(i);  //释放内存，与 AllocHGlobal() 对应

        //}

        public USARTDATA usartdata = new USARTDATA();
        delegate void ShowMessCallback(byte[] message);
        void ShowMessage(byte[] message)
        {
            //            ByteArrayToStructure(InputData, ref usartdata,0);
                        
                        Converter Convert = new Converter();
            USARTDATA usartdata1 = (USARTDATA)Convert.BytesToStruct(message, usartdata.GetType());
                        ulong times = ((ulong)usartdata1.timecounterh)<<32| (ulong)usartdata1.timecounterl;
                        byte id = usartdata1.id;
                        double us = times / 100000.0;
                        if (this.InvokeRequired) this.Invoke(new ShowMessCallback(ShowMessage), new Object[] { message });
                        else
                        {


                            //txtIn.Text = txtIn.Text + " " + message[0];
                            switch (id)
                            {
                                case 1:
                                    {
                                        textBox1.Text = textBox1.Text.Insert(0, us.ToString() + "\r\n");
                                        history1 = textBox1.Text + "\r\n";
                                        break;
                                    }

                                case 2:
                                    {
                                        textBox2.Text = textBox2.Text.Insert(0, us.ToString() + "\r\n");
                                        history2 = textBox2.Text + "\r\n";
                                        break;
                                    }
                                case 3:
                                    {
                                        textBox3.Text = textBox3.Text.Insert(0, us.ToString() + "\r\n");
                                        history3 = textBox3.Text + "\r\n";
                                        break;
                                    }
                                case 4 :
                                    {
                                        textBox4.Text = textBox4.Text.Insert(0, us.ToString() + "\r\n");
                                        history4 = textBox4.Text + "\r\n";
                                        break;
                                    }
                                case 5 :
                                    {
                                        textBox5.Text = textBox5.Text.Insert(0, us.ToString() + "\r\n");
                                        history5 = textBox5.Text + "\r\n";
                                        break;
                                    }
                                case 6 :
                                    {
                                        textBox6.Text = textBox6.Text.Insert(0, us.ToString() + "\r\n");
                                        history6 = textBox6.Text + "\r\n";
                                        break;
                                    }
                                case 7 :
                                    {
                                        textBox7.Text = textBox7.Text.Insert(0, us.ToString() + "\r\n");
                                        history7 = textBox7.Text + "\r\n";
                                        break;
                                    }
                                case 8 :
                                    {
                                        textBox8.Text = textBox8.Text.Insert(0, us.ToString() + "\r\n");
                                        history8 = textBox8.Text + "\r\n";
                                        break;
                                    }
                                case 9 :
                                    {
                                        textBox9.Text = textBox9.Text.Insert(0, us.ToString() + "\r\n");
                                        history9 = textBox9.Text + "\r\n";
                                        break;
                                    }
                                case 10 :
                                    {
                                        textBox10.Text = textBox10.Text.Insert(0, us.ToString() + "\r\n");
                                        history10 = textBox10.Text + "\r\n";
                                        break;
                                    }
                                //11-20
                                case 11 :
                                    {
                                        textBox11.Text = textBox11.Text.Insert(0, us.ToString() + "\r\n");
                                        history11 = textBox11.Text + "\r\n";
                                        break;
                                    }
                                case 12 :
                                    {
                                        textBox12.Text = textBox12.Text.Insert(0, us.ToString() + "\r\n");
                                        history12 = textBox12.Text + "\r\n";
                                        break;
                                    }
                                case 13 :
                                    {
                                        textBox13.Text = textBox13.Text.Insert(0, us.ToString() + "\r\n");
                                        history13 = textBox13.Text + "\r\n";
                                        break;
                                    }
                                case  14:
                                    {
                                        textBox14.Text = textBox14.Text.Insert(0, us.ToString() + "\r\n");
                                        history14 = textBox14.Text + "\r\n";
                                        break;
                                    }
                                case 15 :
                                    {
                                        textBox15.Text = textBox15.Text.Insert(0, us.ToString() + "\r\n");
                                        history15 = textBox15.Text + "\r\n";
                                        break;
                                    }
                                case 16 :
                                    {
                                        textBox16.Text = textBox16.Text.Insert(0, us.ToString() + "\r\n");
                                        history16 = textBox16.Text + "\r\n";
                                        break;
                                    }
                                case 17 :
                                    {
                                        textBox17.Text = textBox17.Text.Insert(0, us.ToString() + "\r\n");
                                        history17 = textBox17.Text + "\r\n";
                                        break;
                                    }
                                case 18:
                                    {
                                        textBox18.Text = textBox18.Text.Insert(0, us.ToString() + "\r\n");
                                        history18 = textBox18.Text + "\r\n";
                                        break;
                                    }
                                case 19 :
                                    {
                                        textBox19.Text = textBox19.Text.Insert(0, us.ToString() + "\r\n");
                                        history19 = textBox19.Text + "\r\n";
                                        break;
                                    }
                                case 20 :
                                    {
                                        textBox20.Text = textBox20.Text.Insert(0, us.ToString() + "\r\n");
                                        history20 = textBox20.Text + "\r\n";
                                        break;
                                    }
                                //20-30
                                case 21 :
                                    {
                                        textBox21.Text = textBox21.Text.Insert(0, us.ToString() + "\r\n");
                                        history21 = textBox21.Text + "\r\n";
                                        break;
                                    }
                                case 22:
                                    {
                                        textBox22.Text = textBox22.Text.Insert(0, us.ToString() + "\r\n");
                                        history22 = textBox22.Text + "\r\n";
                                        break;
                                    }
                                case 23 :
                                    {
                                        textBox23.Text = textBox23.Text.Insert(0, us.ToString() + "\r\n");
                                        history23 = textBox23.Text + "\r\n";
                                        break;
                                    }
                                case 24 :
                                    {
                                        textBox24.Text = textBox24.Text.Insert(0, us.ToString() + "\r\n");
                                        history24 = textBox24.Text + "\r\n";
                                        break;
                                    }
                                case 25 :
                                    {
                                        textBox25.Text = textBox25.Text.Insert(0, us.ToString() + "\r\n");
                                        history25 = textBox25.Text + "\r\n";
                                        break;
                                    }
                                case 26 :
                                    {
                                        textBox26.Text = textBox26.Text.Insert(0, us.ToString() + "\r\n");
                                        history26 = textBox26.Text + "\r\n";
                                        break;
                                    }
                                case 27 :
                                    {
                                        textBox27.Text = textBox27.Text.Insert(0, us.ToString() + "\r\n");
                                        history27 = textBox27.Text + "\r\n";
                                        break;
                                    }
                                case 28 :
                                    {
                                        textBox28.Text = textBox28.Text.Insert(0, us.ToString() + "\r\n");
                                        history28 = textBox28.Text + "\r\n";
                                        break;
                                    }
                                case 29 :
                                    {
                                        textBox29.Text = textBox29.Text.Insert(0, us.ToString() + "\r\n");
                                        history29 = textBox29.Text + "\r\n";
                                        break;
                                    }
                                case 30 :
                                    {
                                        textBox30.Text = textBox30.Text.Insert(0, us.ToString() + "\r\n");
                                        history30 = textBox30.Text + "\r\n";
                                        break;
                                    }
                            }

                        }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fclsRS232Tester_Load(object sender, EventArgs e)
        {
            //this.MaximumSize = this.Size;
            //this.MinimumSize = this.Size;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox30.Text = "";
            textBox29.Text = "";
            textBox28.Text = "";
            textBox27.Text = "";
            textBox26.Text = "";
            textBox25.Text = "";
            textBox24.Text = "";
            textBox23.Text = "";
            textBox22.Text = "";
            textBox21.Text = "";
            textBox20.Text = "";
            textBox19.Text = "";
            textBox18.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String filename = System.DateTime.Now.ToString("yyyy年MM月dd日HH_mm_ss") +".txt";
            FileStream fs = new FileStream(@"d:\" + filename, FileMode.OpenOrCreate);    //首先创建一个文件流
            StreamWriter sw = new StreamWriter(fs);    //创建写入器
            history = "第一路\r\n" + history1 + "第二路\r\n" + history2 + "第三路\r\n" + history3 + "第四路\r\n" + history4 + "第五路\r\n" + history5 + "第六路\r\n" + history6 + "第七路\r\n" + history7 + "第八路\r\n" + history8
                          + "第九路\r\n" + history9 + "第十路\r\n" + history10 + "第十一路\r\n" + history11 + "第十二路\r\n" + history12 + "第十三路\r\n" + history13 + "第十四路\r\n" + history14 + "第十五路\r\n" + history15 + "第十六路\r\n" + history16
                          + "第十七路\r\n" + history17 + "第十八路\r\n" + history18 + "第十九路\r\n" + history19 + "第二十路\r\n" + history20 + "第二十一路\r\n" + history21 + "第二十二路\r\n" + history22 + "第二十三路\r\n" + history23
                           + "第二十四路\r\n" + history24 + "第二十五路\r\n" + history25 + "第二十六路\r\n" + history26 + "第二十七路\r\n" + history27 + "第二十八路\r\n" + history28 + "第二十九路\r\n" + history29 + "第三十路\r\n" + history30;
            sw.WriteLine(history);   //将内容写入文件
            sw.Close();  //关闭写入器
            fs.Close();   //关闭文件流
            MessageBox.Show("文件已保存在D盘下，保存成功","小提示");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtIn_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbComSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            port.Write(sendbuf1, 0, 6);
            label33.Text = "系统运行中";
        }
        private void button1_Click_4(object sender, EventArgs e)
        {
            port.Write(sendbuf2, 0, 6);
            label33.Text = "系统暂停中";
        }
        private void button1_Click_5(object sender, EventArgs e)
        {
            port.Write(sendbuf3, 0, 6);
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }
    }
}
