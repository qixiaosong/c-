using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace kc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string s = "";
            int count = mySerialPort.BytesToRead;

            byte[] data = new byte[count];
            mySerialPort.Read(data, 0, count);

            foreach (byte item in data)
            {
                s += Convert.ToChar(item);
            }

            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { this.textBox1.Text = s; }));
            }
            else
            {
                this.textBox1.Text = s;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!mySerialPort.IsOpen)
            {
                mySerialPort.Open();//打开端口，进行监控  


            }

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen)
                mySerialPort.Close();
        }
    }
}