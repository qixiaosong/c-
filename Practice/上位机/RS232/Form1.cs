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
        char flag = '1';
        String history="";

        
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (port.IsOpen) port.WriteLine(txtOut.Text);
            else MessageBox.Show("Serial port is closed!", "RS232 tester", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtOut.Clear();
        }

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

                if ((InputData.IndexOf('f') == 0) && (InputData.IndexOf('b') == 1))
                {
                    textBox1.Text = "0";
                    textBox3.Text = textBox3.Text + "��λ00" + "\r\n";
                    textBox4.Text = textBox4.Text + System.DateTime.Now.ToString() + "\r\n";
                    history = history + "��λ00" + ":" + System.DateTime.Now.ToString() + "\r\n"; ;
                }
                else if (InputData.IndexOf('1') >= 0)
                {
                    textBox1.Text = "1";
                    textBox3.Text = textBox3.Text + "��λ01" + "\r\n";
                    textBox4.Text = textBox4.Text + System.DateTime.Now.ToString() + "\r\n";
                    history = history + "��λ01" + ":" + System.DateTime.Now.ToString() + "\r\n"; ;
                }
                else if (InputData.IndexOf('2') >= 0)
                {
                    textBox1.Text = "2";
                    textBox3.Text = textBox3.Text + "��λ02" + "\r\n";
                    textBox4.Text = textBox4.Text + System.DateTime.Now.ToString() + "\r\n";
                    history = history + "��λ02" + ":" + System.DateTime.Now.ToString() + "\r\n"; ;
                }


                    if (InputData.IndexOf('A') >=0)
                    {
                        textBox2.Text = "��������";
                    }
                    else if (InputData.IndexOf('B') >= 0)
                    {
                        textBox2.Text = "����";
                    }
                    else if (InputData.IndexOf('C') >= 0)
                    {
                        textBox2.Text = "��ҩ";
                    }
                    else if (InputData.IndexOf('D') >= 0)
                    {
                        textBox2.Text = "��ѯ";
                    }
                    else
                    {
                        textBox2.Text = "����";
                    }
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            String filename = System.DateTime.Now.Day.ToString()+".txt";
            FileStream fs = new FileStream(@"d:\" + filename, FileMode.OpenOrCreate);    //���ȴ���һ���ļ���
            StreamWriter sw = new StreamWriter(fs);    //����д����
            sw.WriteLine(history);   //������д���ļ�
            sw.Close();  //�ر�д����
            fs.Close();   //�ر��ļ���
            MessageBox.Show("����ɹ�");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
