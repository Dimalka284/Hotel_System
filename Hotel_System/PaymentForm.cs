using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminMainForm admin  = new AdminMainForm();
            admin.Show();
            this.Hide();
        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(bookingidtxt.Text) ||
                string.IsNullOrWhiteSpace(amounttxt.Text) ||
                string.IsNullOrWhiteSpace(paymentmtxt.Text))
            {
                MessageBox.Show("Please fill in all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int bookingid  = int.Parse(bookingidtxt.Text);
            int amount = int.Parse(amounttxt.Text);

            Payment payment = new Payment(bookingid, amount, paymentmtxt.Text);
            payment.Process_Payment(payment);
            MessageBox.Show("Payment processed successfully. Thank you!", "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bookingidtxt.Clear();
            amounttxt.Clear();
            paymentmtxt.Clear();
        }

        private void refundbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bookingidtxt.Text))
            {
                MessageBox.Show("Please enter the booking ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(bookingidtxt.Text, out int bookingId))
            {
                MessageBox.Show("Booking ID must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create Payment object
            Payment payment = new Payment(bookingId);

            // Call refund method (better from a service class or static method)
            bool isRefunded = payment.Refund(payment);

            if (isRefunded)
            {
                MessageBox.Show("Refund processed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Refund failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
