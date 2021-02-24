using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebServicce;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //public WebService1 WebService = new WebService1();
        private ServiceReference1.WebService1SoapClient client1;
        public int a,b;
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            client1 = new ServiceReference1.WebService1SoapClient();
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            int result = client1.Subtract(a, b);
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            client1 = new ServiceReference1.WebService1SoapClient();
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            int result = client1.Multiply(a, b);
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            client1 = new ServiceReference1.WebService1SoapClient();
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            int result = client1.Divide(a, b);
            textBox3.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client1 = new ServiceReference1.WebService1SoapClient();
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            int result = client1.Add(a, b);
            textBox3.Text = result.ToString();
        }
    }
}
