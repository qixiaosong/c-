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
        byte[] InputData = new byte[4];
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
            port.BaudRate = 38400;
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
        byte[] num = new byte[1];
        DateTime t2;
        TimeSpan ts;
        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            t2 = System.DateTime.Now;
            ts = t1.Subtract(t2).Duration();

           InputData[0] = Convert.ToByte(port.ReadByte());
           InputData[1] = Convert.ToByte(port.ReadByte());
           InputData[2] = Convert.ToByte(port.ReadByte());
           InputData[3] = Convert.ToByte(port.ReadByte());

            if (InputData[1] == 49)
            {
                num[0] = 01;
                
            }
            if (InputData[1] == 50)
            {
                num[0] = 02;
            }
            if (InputData[1] == 51)
            {
                num[0] = 03;
            }

            ShowMessage(num);
        }
        delegate void ShowMessCallback(byte[] message);
        void ShowMessage(byte[] message)
        {
            if (this.InvokeRequired) this.Invoke(new ShowMessCallback(ShowMessage), new Object[] { message });
            else
            {
                //txtIn.Text = txtIn.Text + " " + message[0];
                if (InputData[0]==48 && InputData[1] == 49)
                {
                    textBox1.Text = textBox1.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history1 = textBox1.Text + "\r\n";
                }
                if (InputData[0] == 48 && InputData[1] == 50)
                {
                    textBox2.Text = textBox2.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history2 = textBox2.Text + "\r\n";
                }
                if (InputData[0] == 48 && InputData[1] == 51)
                {
                    textBox3.Text = textBox3.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history3 = textBox3.Text + "\r\n";
                }
                if (InputData[0] == 48 && InputData[1] == 52)
                {
                    textBox4.Text = textBox4.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history4 = textBox4.Text + "\r\n";
                }
                if (InputData[0] == 48 && InputData[1] == 53)
                {
                    textBox5.Text = textBox5.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history5 = textBox5.Text + "\r\n";
                }
                if (InputData[0] == 48 && InputData[1] == 54)
                {
                    textBox6.Text = textBox6.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history6 = textBox6.Text + "\r\n";
                }
                if (InputData[0] == 48 && InputData[1] == 55)
                {
                    textBox7.Text = textBox7.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history7 = textBox7.Text + "\r\n";
                }
                if (InputData[0] == 48 && InputData[1] == 56)
                {
                    textBox8.Text = textBox8.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history8 = textBox8.Text + "\r\n";
                }
                if (InputData[0] == 48 && InputData[1] == 57)
                {
                    textBox9.Text = textBox9.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history9 = textBox9.Text + "\r\n";
                }
                if (InputData[0] == 49 && InputData[1] == 48)
                {
                    textBox10.Text = textBox10.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history10 = textBox10.Text + "\r\n";
                }
                //11-20
                if (InputData[0] == 49 && InputData[1] == 49)
                {
                    textBox11.Text = textBox11.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history11 = textBox11.Text + "\r\n";
                }
                if (InputData[0] == 49 && InputData[1] == 50)
                {
                    textBox12.Text = textBox12.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history12 = textBox12.Text + "\r\n";
                }
                if (InputData[0] == 49 && InputData[1] == 51)
                {
                    textBox13.Text = textBox13.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history13 = textBox13.Text + "\r\n";
                }
                if (InputData[0] == 49 && InputData[1] == 52)
                {
                    textBox14.Text = textBox14.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history14 = textBox14.Text + "\r\n";
                }
                if (InputData[0] == 49 && InputData[1] == 53)
                {
                    textBox15.Text = textBox15.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history15 = textBox15.Text + "\r\n";
                }
                if (InputData[0] == 49 && InputData[1] == 54)
                {
                    textBox16.Text = textBox16.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history16 = textBox16.Text + "\r\n";
                }
                if (InputData[0] == 49 && InputData[1] == 55)
                {
                    textBox17.Text = textBox17.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history17 = textBox17.Text + "\r\n";
                }
                if (InputData[0] == 49 && InputData[1] == 56)
                {
                    textBox18.Text = textBox18.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history18 = textBox18.Text + "\r\n";
                }
                if (InputData[0] == 49 && InputData[1] == 57)
                {
                    textBox19.Text = textBox19.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history19 = textBox19.Text + "\r\n";
                }
                if (InputData[0] == 50 && InputData[1] == 48)
                {
                    textBox20.Text = textBox20.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history20 = textBox20.Text + "\r\n";
                }
                //20-30
                if (InputData[0] == 50 && InputData[1] == 49)
                {
                    textBox21.Text = textBox21.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history21 = textBox21.Text + "\r\n";
                }
                if (InputData[0] == 50 && InputData[1] == 50)
                {
                    textBox22.Text = textBox22.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history22 = textBox22.Text + "\r\n";
                }
                if (InputData[0] == 50 && InputData[1] == 51)
                {
                    textBox23.Text = textBox23.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history23 = textBox23.Text + "\r\n";
                }
                if (InputData[0] == 50 && InputData[1] == 52)
                {
                    textBox24.Text = textBox24.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history24 = textBox24.Text + "\r\n";
                }
                if (InputData[0] == 50 && InputData[1] == 53)
                {
                    textBox25.Text = textBox25.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history25 = textBox25.Text + "\r\n";
                }
                if (InputData[0] == 50 && InputData[1] == 54)
                {
                    textBox26.Text = textBox26.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history26 = textBox26.Text + "\r\n";
                }
                if (InputData[0] == 50 && InputData[1] == 55)
                {
                    textBox27.Text = textBox27.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history27 = textBox27.Text + "\r\n";
                }
                if (InputData[0] == 50 && InputData[1] == 56)
                {
                    textBox28.Text = textBox28.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history28 = textBox28.Text + "\r\n";
                }
                if (InputData[0] == 50 && InputData[1] == 57)
                {
                    textBox29.Text = textBox29.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history29 = textBox29.Text + "\r\n";
                }
                if (InputData[0] == 51 && InputData[1] == 48)
                {
                    textBox30.Text = textBox30.Text.Insert(0, ts.TotalSeconds.ToString() + "\r\n");
                    history30 = textBox30.Text + "\r\n";
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
            String filename = System.DateTime.Now.ToString("yyyy��MM��dd��HH_mm_ss") +".txt";
            FileStream fs = new FileStream(@"d:\" + filename, FileMode.OpenOrCreate);    //���ȴ���һ���ļ���
            StreamWriter sw = new StreamWriter(fs);    //����д����
            history = "��һ·\r\n" + history1 + "�ڶ�·\r\n" + history2 + "����·\r\n" + history3 + "����·\r\n" + history4 + "����·\r\n" + history5 + "����·\r\n" + history6 + "����·\r\n" + history7 + "�ڰ�·\r\n" + history8
                          + "�ھ�·\r\n" + history9 + "��ʮ·\r\n" + history10 + "��ʮһ·\r\n" + history11 + "��ʮ��·\r\n" + history12 + "��ʮ��·\r\n" + history13 + "��ʮ��·\r\n" + history14 + "��ʮ��·\r\n" + history15 + "��ʮ��·\r\n" + history16
                          + "��ʮ��·\r\n" + history17 + "��ʮ��·\r\n" + history18 + "��ʮ��·\r\n" + history19 + "�ڶ�ʮ·\r\n" + history20 + "�ڶ�ʮһ·\r\n" + history21 + "�ڶ�ʮ��·\r\n" + history22 + "�ڶ�ʮ��·\r\n" + history23
                           + "�ڶ�ʮ��·\r\n" + history24 + "�ڶ�ʮ��·\r\n" + history25 + "�ڶ�ʮ��·\r\n" + history26 + "�ڶ�ʮ��·\r\n" + history27 + "�ڶ�ʮ��·\r\n" + history28 + "�ڶ�ʮ��·\r\n" + history29 + "����ʮ·\r\n" + history30;
            sw.WriteLine(history);   //������д���ļ�
            sw.Close();  //�ر�д����
            fs.Close();   //�ر��ļ���
            MessageBox.Show("�ļ��ѱ�����D���£�����ɹ�","С��ʾ");
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
    }
}
