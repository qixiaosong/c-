using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double L = double.Parse(textBox1.Text);
            Double C = double.Parse(textBox2.Text);
            Double F = 1 / (2 * Math.PI * Math.Sqrt(L * C));
            textBox4.Text = F.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double L = double.Parse(textBox1.Text);
            Double F = double.Parse(textBox3.Text);
            Double C = (1/(2*Math.PI*F))* (1 / (2 * Math.PI * F))/L;
            textBox4.Text = C.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double C = double.Parse(textBox2.Text);
            Double F = double.Parse(textBox3.Text);
            Double L = (1 / (2 * Math.PI * F)) * (1 / (2 * Math.PI * F)) / C;
            textBox4.Text = L.ToString();
        }
    }
}
