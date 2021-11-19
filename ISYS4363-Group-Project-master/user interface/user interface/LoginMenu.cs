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
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f2 = new LoginForm();
            f2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogin f2 = new EmployeeLogin();
            f2.Show();
        }

        
    }
}
