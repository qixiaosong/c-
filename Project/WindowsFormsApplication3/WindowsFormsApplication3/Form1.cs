using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox3.Text.Length == 0 && textBox1.Text.Length != 0 && textBox1.Text.Length != 0)
            {
                Double L = double.Parse(textBox1.Text);
                Double C = double.Parse(textBox2.Text);
                Double F1 = 1 / (2 * Math.PI * Math.Sqrt(L * C));
                textBox3.Text = F1.ToString();
            }
            if (textBox2.Text.Length == 0 && textBox1.Text.Length != 0 && textBox3.Text.Length != 0)
            {
                Double L = double.Parse(textBox1.Text);
                Double F = double.Parse(textBox3.Text);
                Double C1 = (1 / (2 * Math.PI * F)) * (1 / (2 * Math.PI * F)) / L;
                textBox2.Text = C1.ToString();
            }
            if(textBox1.Text.Length == 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0)
            {
                Double C = double.Parse(textBox2.Text);
                Double F = double.Parse(textBox3.Text);
                Double L1 = (1 / (2 * Math.PI * F)) * (1 / (2 * Math.PI * F)) / C;
                textBox1.Text = L1.ToString();
            }
        }


    }
}
