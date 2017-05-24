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
        string InputData = String.Empty;
//        char flag = '1';
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

        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control:
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
            stsStatus.Text = port.PortName + ": 9600,8N1";

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
        }

        //private void btnSend_Click(object sender, EventArgs e)
        //{
        //    //if (port.IsOpen) port.WriteLine(txtOut.Text);
        //    //else MessageBox.Show("Serial port is closed!", "RS232 tester", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //txtOut.Clear();
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIn.Clear();
        }

        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = port.ReadExisting();
           
            if (InputData != String.Empty)
            {
 //             txtIn.Text = InputData;   // because of different threads this does not work properly !!
                SetText(InputData);
            }
        }

        /*
        To make a thread-safe call a Windows Forms control:

        1.  Query the control's InvokeRequired property.
        2.  If InvokeRequired returns true,  call Invoke with a delegate that makes the actual call to the control.
        3.  If InvokeRequired returns false, call the control directly.

        In the following code example, this logic is implemented in a utility method called SetText. 
        A delegate type named SetTextDelegate encapsulates the SetText method. 
        When the TextBox control's InvokeRequired returns true, the SetText method creates an instance
        of SetTextDelegate and calls the form's Invoke method. 
        This causes the SetText method to be called on the thread that created the TextBox control,
        and in this thread context the Text property is set directly

        also see: http://msdn2.microsoft.com/en-us/library/ms171728(VS.80).aspx
        */

        // This method demonstrates a pattern for making thread-safe
        // calls on a Windows Forms control. 
        //
        // If the calling thread is different from the thread that
        // created the TextBox control, this method creates a
        // SetTextCallback and calls itself asynchronously using the
        // Invoke method.
        //
        // If the calling thread is the same as the thread that created
        // the TextBox control, the Text property is set directly. 
       
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtIn.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtIn.Text += text;

                DateTime t2 = System.DateTime.Now;
                TimeSpan ts = t1.Subtract(t2).Duration();

                    //if (InputData.IndexOf("30") == 0)
                    //{
                    ////textBox30.Text = textBox30.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox30.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history30 = textBox30.Text + "\r\n"; 
                    //}
                    //else if (InputData.IndexOf("29") == 0)
                    //{
                    ////textBox29.Text = textBox29.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox29.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history29 = textBox29.Text + "\r\n"; 
                    //}
                    //else if (InputData.IndexOf("28") == 0)
                    //{
                    ////textBox28.Text = textBox28.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox28.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history28 = textBox28.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("27") == 0)
                    //{
                    ////textBox27.Text = textBox27.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox27.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history27 = textBox27.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("26") == 0)
                    //{
                    ////textBox26.Text = textBox26.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox26.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history26 = textBox26.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("25") == 0)
                    //{
                    ////textBox25.Text = textBox25.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox25.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history25 = textBox25.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("24") == 0)
                    //{
                    ////textBox24.Text = textBox24.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox24.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history24 = textBox24.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("23") == 0)
                    //{
                    ////textBox23.Text = textBox23.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox23.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history23 = textBox23.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("22") == 0)
                    //{
                    ////textBox22.Text = textBox22.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox22.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history22 = textBox22.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("21") == 0)
                    //{
                    ////textBox21.Text = textBox21.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox21.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history21 = textBox21.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("20") == 0)
                    //{
                    ////textBox20.Text = textBox20.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox20.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history20 = textBox20.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("19") == 0)
                    //{
                    ////textBox19.Text = textBox19.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox19.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history19 = textBox19.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("18") == 0)
                    //{
                    ////textBox18.Text = textBox18.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox18.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history18 = textBox18.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("17") == 0)
                    //{
                    ////textBox17.Text = textBox17.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox17.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history17 = textBox17.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("16") == 0)
                    //{
                    //// textBox16.Text = textBox16.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox16.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history16 = textBox16.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("15") == 0)
                    //{
                    //// textBox15.Text = textBox15.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox15.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history15 = textBox15.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("14") == 0)
                    //{
                    ////textBox14.Text = textBox14.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox14.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history14 = textBox14.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("13") == 0)
                    //{
                    ////textBox13.Text = textBox13.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox13.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history13 = textBox13.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("12") == 0)
                    //{
                    ////textBox12.Text = textBox12.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox12.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history12 = textBox12.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("11") == 0)
                    //{
                    ////textBox11.Text = textBox11.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox11.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history11 = textBox11.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("10") == 0)
                    //{
                    ////textBox10.Text = textBox10.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox10.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history10 = textBox10.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("09") == 0)
                    //{
                    //// textBox9.Text = textBox9.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox9.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history9 = textBox9.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("08") == 0)
                    //{
                    ////textBox8.Text = textBox8.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox9.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history8 = textBox8.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("07") == 0)
                    //{
                    ////textBox7.Text = textBox7.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox7.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history7 = textBox7.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("06") == 0)
                    //{
                    //// textBox6.Text = textBox6.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox6.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history6 = textBox6.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("05") == 0)
                    //{
                    //// textBox5.Text = textBox5.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox5.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history5 = textBox5.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("04") == 0)
                    //{
                    //// textBox4.Text = textBox4.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox4.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history4 = textBox4.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("03") == 0)
                    //{
                    //// textBox3.Text = textBox3.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox3.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history3 = textBox3.Text + "\r\n";
                    //}
                    //else if (InputData.IndexOf("02") == 0)
                    //{
                    ////textBox2.Text = textBox2.Text + ts.TotalSeconds.ToString() + "\r\n";
                    //textBox2.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    //history2 = textBox2.Text + "\r\n";
                    //}
                    if (InputData.IndexOf("01") == 0)
                    {

                    //textBox1.Text = textBox1.Text + ts.TotalSeconds.ToString() + "\r\n";
                    textBox1.AppendText(ts.TotalSeconds.ToString() + "\r\n");
                    history1 = textBox1.Text + "\r\n";
                    }

                //else
                //{
                //    //textBox1.Text = "000";
                //    textBox1.AppendText("000" + "\r\n");
                //}

            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fclsRS232Tester_Load(object sender, EventArgs e)
        {

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
           
            String filename = System.DateTime.Now.ToString("yyyy年MM月dd日hh_mm_ss") +".txt";
            FileStream fs = new FileStream(@"d:\" + filename, FileMode.OpenOrCreate);    //首先创建一个文件流
            StreamWriter sw = new StreamWriter(fs);    //创建写入器
            history = "第一路\r\n" + history1 + "第二路\r\n" + history2 + "第三路\r\n" + history3 + "第四路\r\n" + history4 + "第五路\r\n" + history5 + "第六路\r\n" + history6 + "第七路\r\n" + history7 + "第八路\r\n" + history8
                          + "第九路\r\n" + history9 + "第十路\r\n" + history10 + "第十一路\r\n" + history11 + "第十二路\r\n" + history12 + "第十三路\r\n" + history13 + "第十四路\r\n" + history14 + "第十五路\r\n" + history15 + "第十六路\r\n" + history16
                          + "第十七路\r\n" + history17 + "第十八路\r\n" + history18 + "第十九路\r\n" + history19 + "第二十路\r\n" + history20 + "第二十一路\r\n" + history21 + "第二十二路\r\n" + history22 + "第二十三路\r\n" + history23
                           + "第二十四路\r\n" + history24 + "第二十五路\r\n" + history25 + "第二十六路\r\n" + history26 + "第二十七路\r\n" + history27 + "第二十八路\r\n" + history28 + "第二十九路\r\n" + history29 + "第三十路\r\n" + history30;
            sw.WriteLine(history);   //将内容写入文件
            sw.Close();  //关闭写入器
            fs.Close();   //关闭文件流
            MessageBox.Show("保存成功");
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

        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{

        //}

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
    }
}
