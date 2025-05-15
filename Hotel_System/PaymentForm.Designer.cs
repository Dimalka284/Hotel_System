namespace Hotel_System
{
    partial class PaymentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingidtxt = new System.Windows.Forms.TextBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.paymentmtxt = new System.Windows.Forms.TextBox();
            this.paymentidtxt = new System.Windows.Forms.TextBox();
            this.paymentbtn = new System.Windows.Forms.Button();
            this.refundbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thank You";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 359);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Booking_Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amout";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payment_Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Payment_ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(399, 384);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookingidtxt
            // 
            this.bookingidtxt.Location = new System.Drawing.Point(103, 125);
            this.bookingidtxt.Name = "bookingidtxt";
            this.bookingidtxt.Size = new System.Drawing.Size(292, 22);
            this.bookingidtxt.TabIndex = 7;
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(103, 171);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(292, 22);
            this.amounttxt.TabIndex = 8;
            // 
            // paymentmtxt
            // 
            this.paymentmtxt.Location = new System.Drawing.Point(129, 223);
            this.paymentmtxt.Name = "paymentmtxt";
            this.paymentmtxt.Size = new System.Drawing.Size(266, 22);
            this.paymentmtxt.TabIndex = 9;
            // 
            // paymentidtxt
            // 
            this.paymentidtxt.Location = new System.Drawing.Point(103, 265);
            this.paymentidtxt.Name = "paymentidtxt";
            this.paymentidtxt.Size = new System.Drawing.Size(292, 22);
            this.paymentidtxt.TabIndex = 10;
            // 
            // paymentbtn
            // 
            this.paymentbtn.Location = new System.Drawing.Point(26, 332);
            this.paymentbtn.Name = "paymentbtn";
            this.paymentbtn.Size = new System.Drawing.Size(141, 42);
            this.paymentbtn.TabIndex = 11;
            this.paymentbtn.Text = "Process_Payment.";
            this.paymentbtn.UseVisualStyleBackColor = true;
            this.paymentbtn.Click += new System.EventHandler(this.paymentbtn_Click);
            // 
            // refundbtn
            // 
            this.refundbtn.Location = new System.Drawing.Point(25, 393);
            this.refundbtn.Name = "refundbtn";
            this.refundbtn.Size = new System.Drawing.Size(142, 42);
            this.refundbtn.TabIndex = 12;
            this.refundbtn.Text = "Issue_Refund";
            this.refundbtn.UseVisualStyleBackColor = true;
            this.refundbtn.Click += new System.EventHandler(this.refundbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(703, 485);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 48);
            this.backbtn.TabIndex = 13;
            this.backbtn.Text = "Back ";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.refundbtn);
            this.Controls.Add(this.paymentbtn);
            this.Controls.Add(this.paymentidtxt);
            this.Controls.Add(this.paymentmtxt);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.bookingidtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox bookingidtxt;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.TextBox paymentmtxt;
        private System.Windows.Forms.TextBox paymentidtxt;
        private System.Windows.Forms.Button paymentbtn;
        private System.Windows.Forms.Button refundbtn;
        private System.Windows.Forms.Button backbtn;
    }
}