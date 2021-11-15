using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_interface
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user1" && textBox2.Text == "myPswd")
            {
                new CustomerMenu(this).Show();
                this.Hide();
            } 
            else
            {
                MessageBox.Show("Invalid User name or Password");
                textBox1.Focus();
            }
        }
    }
}
