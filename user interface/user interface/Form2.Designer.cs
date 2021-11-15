
namespace user_interface
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewVehicle = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnUsedVehicle = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMyFavs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.Location = new System.Drawing.Point(52, 16);
            this.btnNewVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewVehicle.Name = "btnNewVehicle";
            this.btnNewVehicle.Size = new System.Drawing.Size(88, 61);
            this.btnNewVehicle.TabIndex = 0;
            this.btnNewVehicle.Text = "New Vehicle ";
            this.btnNewVehicle.UseVisualStyleBackColor = true;
            this.btnNewVehicle.Click += new System.EventHandler(this.btnNewVehicle_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(52, 95);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(88, 61);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(248, 16);
            this.btnReview.Margin = new System.Windows.Forms.Padding(2);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(88, 61);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnUsedVehicle
            // 
            this.btnUsedVehicle.Location = new System.Drawing.Point(150, 16);
            this.btnUsedVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsedVehicle.Name = "btnUsedVehicle";
            this.btnUsedVehicle.Size = new System.Drawing.Size(88, 61);
            this.btnUsedVehicle.TabIndex = 3;
            this.btnUsedVehicle.Text = "Used Vehicle";
            this.btnUsedVehicle.UseVisualStyleBackColor = true;
            this.btnUsedVehicle.Click += new System.EventHandler(this.btnUsedVehicle_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(150, 95);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(88, 61);
            this.btnReservation.TabIndex = 4;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(248, 278);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMyFavs
            // 
            this.btnMyFavs.Location = new System.Drawing.Point(248, 95);
            this.btnMyFavs.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyFavs.Name = "btnMyFavs";
            this.btnMyFavs.Size = new System.Drawing.Size(88, 61);
            this.btnMyFavs.TabIndex = 6;
            this.btnMyFavs.Text = "Myfavorite";
            this.btnMyFavs.UseVisualStyleBackColor = true;
            this.btnMyFavs.Click += new System.EventHandler(this.btnMyFavs_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 341);
            this.Controls.Add(this.btnMyFavs);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnUsedVehicle);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnNewVehicle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ride and Drive: Main Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewVehicle;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnUsedVehicle;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMyFavs;
    }
}