
namespace user_interface
{
    partial class CustomerUsedSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMake = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddToFavs = new System.Windows.Forms.Button();
            this.btnAddToReserve = new System.Windows.Forms.Button();
            this.btnHomeRev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(955, 198);
            this.dataGridView1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Used Vehicle Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMake);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbModel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbSize);
            this.groupBox1.Controls.Add(this.cbYear);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 83);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Make";
            // 
            // cbMake
            // 
            this.cbMake.FormattingEnabled = true;
            this.cbMake.Location = new System.Drawing.Point(5, 40);
            this.cbMake.Margin = new System.Windows.Forms.Padding(2);
            this.cbMake.Name = "cbMake";
            this.cbMake.Size = new System.Drawing.Size(127, 21);
            this.cbMake.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Model";
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(181, 40);
            this.cbModel.Margin = new System.Windows.Forms.Padding(2);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(167, 21);
            this.cbModel.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(853, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 36);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Year";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(515, 40);
            this.cbSize.Margin = new System.Windows.Forms.Padding(2);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(62, 21);
            this.cbSize.TabIndex = 8;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(392, 40);
            this.cbYear.Margin = new System.Windows.Forms.Padding(2);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(73, 21);
            this.cbYear.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Size";
            // 
            // btnAddToFavs
            // 
            this.btnAddToFavs.Location = new System.Drawing.Point(696, 372);
            this.btnAddToFavs.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToFavs.Name = "btnAddToFavs";
            this.btnAddToFavs.Size = new System.Drawing.Size(125, 36);
            this.btnAddToFavs.TabIndex = 29;
            this.btnAddToFavs.Text = "Add into Myfavorite";
            this.btnAddToFavs.UseVisualStyleBackColor = true;
            this.btnAddToFavs.Click += new System.EventHandler(this.btnAddToFavs_Click);
            // 
            // btnAddToReserve
            // 
            this.btnAddToReserve.Location = new System.Drawing.Point(835, 372);
            this.btnAddToReserve.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToReserve.Name = "btnAddToReserve";
            this.btnAddToReserve.Size = new System.Drawing.Size(132, 36);
            this.btnAddToReserve.TabIndex = 28;
            this.btnAddToReserve.Text = "Add into Reservation";
            this.btnAddToReserve.UseVisualStyleBackColor = true;
            this.btnAddToReserve.Click += new System.EventHandler(this.btnAddToReserve_Click);
            // 
            // btnHomeRev
            // 
            this.btnHomeRev.Location = new System.Drawing.Point(1, 408);
            this.btnHomeRev.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeRev.Name = "btnHomeRev";
            this.btnHomeRev.Size = new System.Drawing.Size(89, 25);
            this.btnHomeRev.TabIndex = 30;
            this.btnHomeRev.Text = "Home";
            this.btnHomeRev.UseVisualStyleBackColor = true;
            this.btnHomeRev.Click += new System.EventHandler(this.btnHomeRev_Click);
            // 
            // CustomerUsedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 444);
            this.Controls.Add(this.btnHomeRev);
            this.Controls.Add(this.btnAddToFavs);
            this.Controls.Add(this.btnAddToReserve);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "CustomerUsedSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Used Vehicle Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMake;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddToFavs;
        private System.Windows.Forms.Button btnAddToReserve;
        private System.Windows.Forms.Button btnHomeRev;
    }
}