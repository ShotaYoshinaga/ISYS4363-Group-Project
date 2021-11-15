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
    public partial class Form2 : Form
    {
        private LoginForm loginForm = null;
        private DialogResult dr;

        public Form2(LoginForm form1)
        {
            InitializeComponent();
            this.loginForm = form1;
            //form1.Close();
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            Form3 newVehForm = new Form3();
            dr = newVehForm.ShowDialog(this);
            newVehForm = null;
        }

        private void btnUsedVehicle_Click(object sender, EventArgs e)
        {
            Form4 usedVehForm = new Form4();
            dr = usedVehForm.ShowDialog(this);
            usedVehForm = null;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            Form7 reviewForm = new Form7();
            dr = reviewForm.ShowDialog(this);
            reviewForm = null;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Form6 profileFrom = new Form6();
            dr = profileFrom.ShowDialog(this);
            profileFrom = null;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Form5 reservForm = new Form5();
            dr = reservForm.ShowDialog(this);
            reservForm = null;
        }

        private void btnMyFavs_Click(object sender, EventArgs e)
        {
            Form11 myFavsForm = new Form11();
            dr = myFavsForm.ShowDialog(this);
            myFavsForm = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure you want to Exit?", "Confirm Exit", MessageBoxButtons.YesNoCancel );
            if (dr == DialogResult.Yes)
            {
                this.loginForm.Close();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure you want to Exit?", "Confirm Exit", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                this.loginForm.Close();
            }
        }
    }
}
