using BankForm.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm
{
    public partial class Form2 : Form
    {
        Service1Client client = new Service1Client();
        
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = client.WithDraw(int.Parse(textBox3.Text), int.Parse(textBox1.Text));
            if (result)
            {
                MessageBox.Show("Rut tien thanh cong");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool result = client.Deposit(int.Parse(textBox3.Text), int.Parse(textBox2.Text));
            if (result)
            {
                MessageBox.Show("Gui tien thanh cong");
            }
        }
    }
}
