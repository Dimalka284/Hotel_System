using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bookingbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Validate input
                if (string.IsNullOrWhiteSpace(customeridtxt.Text) || string.IsNullOrWhiteSpace(roomidtxt.Text))
                {
                    MessageBox.Show("Please fill in both Customer ID and Room ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int customerId = Convert.ToInt32(customeridtxt.Text);
                int roomId = Convert.ToInt32(roomidtxt.Text);
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;

                // Step 2: Validate dates
                if (checkOut <= checkIn)
                {
                    MessageBox.Show("Check-out date must be after check-in date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Step 3: Check room availability
                Booking booking = new Booking();
                if (!booking.IsRoomAvailable(roomId, checkIn, checkOut))
                {
                    MessageBox.Show("This room is already booked for the selected dates.", "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Room is available. Proceeding to booking...");

                // Step 4: Create booking object
                booking = new Booking(customerId, roomId, checkIn, checkOut);

                // Step 5: Create booking in database
                bool success = booking.CreatingBooking(booking);

                if (success)
                {
                    MessageBox.Show($"Booking successful!\nTotal Price: Rs. {booking.TotalPrice:N2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Step 6: Navigate to payment form
                    PaymentForm paymentForm = new PaymentForm();
                    paymentForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Booking failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Customer ID and Room ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminMainForm admin = new AdminMainForm();
            admin.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            dataGridView1.DataSource = booking.LoadAllBooking();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            dataGridView2.DataSource = customer.LoadCustomer();
        }

        private void viewallroomsbtn_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            dataGridView2.DataSource = rooms.LoadRooms();
        }
    }
}
