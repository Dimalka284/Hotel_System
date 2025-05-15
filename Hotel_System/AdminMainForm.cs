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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void dashboradbtn_Click(object sender, EventArgs e)
        {
            Booking bookings = new Booking();
            DataTable bookingsToday = bookings.LoadBookingsForToday();

            if (bookingsToday.Rows.Count > 0)
            {
                dataGridView1.DataSource = bookingsToday;
            }
            else
            {
                dataGridView1.DataSource = null; // Optional: clears any old data
                MessageBox.Show("No bookings for today.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roomsbtn_Click(object sender, EventArgs e)
        {
            RoomsAdminform room = new RoomsAdminform();
            room.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\Hotel management System\Sri_lankan.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void customersbtn_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            customer.Show();
            this.Hide();
        }

        private void bookingbtn_Click(object sender, EventArgs e)
        {
            BookingForm bookingform = new BookingForm();    
            bookingform.Show();
            this.Hide();
        }

        private void paymenthistorybtn_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            DataTable payment_history = payment.Payment_History();

            dataGridView1.DataSource = payment_history;
        }
    }
}
