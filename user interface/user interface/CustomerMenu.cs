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
    public partial class CustomerMenu : Form
    {
        private LoginForm loginForm = null;
        private DialogResult dr;

        public CustomerMenu(LoginForm form1)
        {
            InitializeComponent();
            this.loginForm = form1;
            //form1.Close();
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            CustomerNewSearch newVehForm = new CustomerNewSearch();
            dr = newVehForm.ShowDialog(this);
            newVehForm = null;
        }

        private void btnUsedVehicle_Click(object sender, EventArgs e)
        {
            CustomerUsedSearch usedVehForm = new CustomerUsedSearch();
            dr = usedVehForm.ShowDialog(this);
            usedVehForm = null;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            CarReview reviewForm = new CarReview();
            dr = reviewForm.ShowDialog(this);
            reviewForm = null;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            CustomerProfile profileFrom = new CustomerProfile();
            dr = profileFrom.ShowDialog(this);
            profileFrom = null;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Reservation reservForm = new Reservation();
            dr = reservForm.ShowDialog(this);
            reservForm = null;
        }

        private void btnMyFavs_Click(object sender, EventArgs e)
        {
            FavoriteCarList myFavsForm = new FavoriteCarList();
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
