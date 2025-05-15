namespace Hotel_System
{
    partial class RoomsAdminform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.viewallroomsbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.deleteroombtn = new System.Windows.Forms.Button();
            this.updateroombtn = new System.Windows.Forms.Button();
            this.addroomsbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomidtxt = new System.Windows.Forms.TextBox();
            this.isavailabletxt = new System.Windows.Forms.TextBox();
            this.pernighttxt = new System.Windows.Forms.TextBox();
            this.roomtypetxt = new System.Windows.Forms.TextBox();
            this.roomnumbertxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 426);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(875, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 45);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room_Actions";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.backbtn);
            this.panel2.Controls.Add(this.viewallroomsbtn);
            this.panel2.Controls.Add(this.searchbtn);
            this.panel2.Controls.Add(this.deleteroombtn);
            this.panel2.Controls.Add(this.updateroombtn);
            this.panel2.Controls.Add(this.addroomsbtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-18, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 390);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(456, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 204);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(784, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(96, 39);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // viewallroomsbtn
            // 
            this.viewallroomsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.viewallroomsbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewallroomsbtn.Location = new System.Drawing.Point(511, 300);
            this.viewallroomsbtn.Name = "viewallroomsbtn";
            this.viewallroomsbtn.Size = new System.Drawing.Size(131, 39);
            this.viewallroomsbtn.TabIndex = 5;
            this.viewallroomsbtn.Text = "View_All_Rooms";
            this.viewallroomsbtn.UseVisualStyleBackColor = false;
            this.viewallroomsbtn.Click += new System.EventHandler(this.viewallroomsbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.searchbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(740, 224);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(96, 39);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // deleteroombtn
            // 
            this.deleteroombtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.deleteroombtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteroombtn.Location = new System.Drawing.Point(682, 300);
            this.deleteroombtn.Name = "deleteroombtn";
            this.deleteroombtn.Size = new System.Drawing.Size(136, 39);
            this.deleteroombtn.TabIndex = 3;
            this.deleteroombtn.Text = "Delete_Rooms";
            this.deleteroombtn.UseVisualStyleBackColor = false;
            this.deleteroombtn.Click += new System.EventHandler(this.deleteroombtn_Click);
            // 
            // updateroombtn
            // 
            this.updateroombtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.updateroombtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateroombtn.Location = new System.Drawing.Point(598, 224);
            this.updateroombtn.Name = "updateroombtn";
            this.updateroombtn.Size = new System.Drawing.Size(136, 39);
            this.updateroombtn.TabIndex = 2;
            this.updateroombtn.Text = "Update_Rooms";
            this.updateroombtn.UseVisualStyleBackColor = false;
            this.updateroombtn.Click += new System.EventHandler(this.updateroombtn_Click);
            // 
            // addroomsbtn
            // 
            this.addroomsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.addroomsbtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addroomsbtn.Location = new System.Drawing.Point(474, 224);
            this.addroomsbtn.Name = "addroomsbtn";
            this.addroomsbtn.Size = new System.Drawing.Size(106, 39);
            this.addroomsbtn.TabIndex = 1;
            this.addroomsbtn.Text = "Add_Rooms";
            this.addroomsbtn.UseVisualStyleBackColor = false;
            this.addroomsbtn.Click += new System.EventHandler(this.addroomsbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.roomidtxt);
            this.panel3.Controls.Add(this.isavailabletxt);
            this.panel3.Controls.Add(this.pernighttxt);
            this.panel3.Controls.Add(this.roomtypetxt);
            this.panel3.Controls.Add(this.roomnumbertxt);
            this.panel3.Location = new System.Drawing.Point(21, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 387);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Room_ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "IsAvailable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Room_Per_Night";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room_Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Room_Number";
            // 
            // roomidtxt
            // 
            this.roomidtxt.Location = new System.Drawing.Point(20, 337);
            this.roomidtxt.Name = "roomidtxt";
            this.roomidtxt.Size = new System.Drawing.Size(367, 22);
            this.roomidtxt.TabIndex = 4;
            // 
            // isavailabletxt
            // 
            this.isavailabletxt.Location = new System.Drawing.Point(20, 272);
            this.isavailabletxt.Name = "isavailabletxt";
            this.isavailabletxt.Size = new System.Drawing.Size(367, 22);
            this.isavailabletxt.TabIndex = 3;
            // 
            // pernighttxt
            // 
            this.pernighttxt.Location = new System.Drawing.Point(20, 205);
            this.pernighttxt.Name = "pernighttxt";
            this.pernighttxt.Size = new System.Drawing.Size(367, 22);
            this.pernighttxt.TabIndex = 2;
            // 
            // roomtypetxt
            // 
            this.roomtypetxt.Location = new System.Drawing.Point(20, 139);
            this.roomtypetxt.Name = "roomtypetxt";
            this.roomtypetxt.Size = new System.Drawing.Size(367, 22);
            this.roomtypetxt.TabIndex = 1;
            // 
            // roomnumbertxt
            // 
            this.roomnumbertxt.Location = new System.Drawing.Point(20, 75);
            this.roomnumbertxt.Name = "roomnumbertxt";
            this.roomnumbertxt.Size = new System.Drawing.Size(367, 22);
            this.roomnumbertxt.TabIndex = 0;
            // 
            // RoomsAdminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RoomsAdminform";
            this.Text = "RoomsAdminform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomidtxt;
        private System.Windows.Forms.TextBox isavailabletxt;
        private System.Windows.Forms.TextBox pernighttxt;
        private System.Windows.Forms.TextBox roomtypetxt;
        private System.Windows.Forms.TextBox roomnumbertxt;
        private System.Windows.Forms.Button updateroombtn;
        private System.Windows.Forms.Button addroomsbtn;
        private System.Windows.Forms.Button viewallroomsbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button deleteroombtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}