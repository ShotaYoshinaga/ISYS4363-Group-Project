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
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }



        private void BtnEmplo_Click(object sender, EventArgs e)
        {

            this.Hide();
            CarSelection f2 = new CarSelection();
            f2.Show();
        }
    }
}
