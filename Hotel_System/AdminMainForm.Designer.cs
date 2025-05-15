namespace Hotel_System
{
    partial class AdminMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookingbtn = new System.Windows.Forms.Button();
            this.userbtn = new System.Windows.Forms.Button();
            this.customersbtn = new System.Windows.Forms.Button();
            this.roomsbtn = new System.Windows.Forms.Button();
            this.dashboradbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paymenthistorybtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 531);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(311, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 160);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 361);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.paymenthistorybtn);
            this.panel2.Controls.Add(this.bookingbtn);
            this.panel2.Controls.Add(this.userbtn);
            this.panel2.Controls.Add(this.customersbtn);
            this.panel2.Controls.Add(this.roomsbtn);
            this.panel2.Controls.Add(this.dashboradbtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 530);
            this.panel2.TabIndex = 0;
            // 
            // bookingbtn
            // 
            this.bookingbtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bookingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookingbtn.Location = new System.Drawing.Point(76, 360);
            this.bookingbtn.Name = "bookingbtn";
            this.bookingbtn.Size = new System.Drawing.Size(147, 34);
            this.bookingbtn.TabIndex = 5;
            this.bookingbtn.Text = "Bookings";
            this.bookingbtn.UseVisualStyleBackColor = false;
            this.bookingbtn.Click += new System.EventHandler(this.bookingbtn_Click);
            // 
            // userbtn
            // 
            this.userbtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.userbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userbtn.Location = new System.Drawing.Point(76, 305);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(147, 34);
            this.userbtn.TabIndex = 4;
            this.userbtn.Text = "Add_User";
            this.userbtn.UseVisualStyleBackColor = false;
            this.userbtn.Click += new System.EventHandler(this.userbtn_Click);
            // 
            // customersbtn
            // 
            this.customersbtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.customersbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersbtn.Location = new System.Drawing.Point(76, 254);
            this.customersbtn.Name = "customersbtn";
            this.customersbtn.Size = new System.Drawing.Size(147, 34);
            this.customersbtn.TabIndex = 3;
            this.customersbtn.Text = "Customers";
            this.customersbtn.UseVisualStyleBackColor = false;
            this.customersbtn.Click += new System.EventHandler(this.customersbtn_Click);
            // 
            // roomsbtn
            // 
            this.roomsbtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roomsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsbtn.Location = new System.Drawing.Point(76, 197);
            this.roomsbtn.Name = "roomsbtn";
            this.roomsbtn.Size = new System.Drawing.Size(147, 34);
            this.roomsbtn.TabIndex = 2;
            this.roomsbtn.Text = "Rooms";
            this.roomsbtn.UseVisualStyleBackColor = false;
            this.roomsbtn.Click += new System.EventHandler(this.roomsbtn_Click);
            // 
            // dashboradbtn
            // 
            this.dashboradbtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.dashboradbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboradbtn.Location = new System.Drawing.Point(61, 103);
            this.dashboradbtn.Name = "dashboradbtn";
            this.dashboradbtn.Size = new System.Drawing.Size(199, 34);
            this.dashboradbtn.TabIndex = 1;
            this.dashboradbtn.Text = "Today\'s Bookings";
            this.dashboradbtn.UseVisualStyleBackColor = false;
            this.dashboradbtn.Click += new System.EventHandler(this.dashboradbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome User";
            // 
            // paymenthistorybtn
            // 
            this.paymenthistorybtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.paymenthistorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymenthistorybtn.Location = new System.Drawing.Point(61, 459);
            this.paymenthistorybtn.Name = "paymenthistorybtn";
            this.paymenthistorybtn.Size = new System.Drawing.Size(199, 34);
            this.paymenthistorybtn.TabIndex = 6;
            this.paymenthistorybtn.Text = "Payment History";
            this.paymenthistorybtn.UseVisualStyleBackColor = false;
            this.paymenthistorybtn.Click += new System.EventHandler(this.paymenthistorybtn_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 536);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userbtn;
        private System.Windows.Forms.Button customersbtn;
        private System.Windows.Forms.Button roomsbtn;
        private System.Windows.Forms.Button dashboradbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bookingbtn;
        private System.Windows.Forms.Button paymenthistorybtn;
    }
}