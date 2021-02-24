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
    public partial class Form1 : Form
    {
        Service1Client client = new Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool result = client.ValidateAccount(int.Parse(textBox1.Text), textBox2.Text);
            if (result)
            {
                Form2 fm2 = new Form2();
                fm2.Show();
                
            }
            else
            {
                MessageBox.Show("Enter information again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
        }
    }
}
