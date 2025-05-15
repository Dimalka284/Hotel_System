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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.Show();
            this.Hide();

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(fullnametxt.Text) || string.IsNullOrWhiteSpace(emailtxt.Text) || string.IsNullOrWhiteSpace(phonenumbertxt.Text) || string.IsNullOrWhiteSpace(addresstxt.Text))
            {
                MessageBox.Show("Please enter the details correctly","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Customer customer = new Customer(fullnametxt.Text,emailtxt.Text,phonenumbertxt.Text,addresstxt.Text);
            customer.Register(customer);
            MessageBox.Show("Customer Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fullnametxt.Clear();
            emailtxt.Clear();
            phonenumbertxt.Clear();
            addresstxt.Clear();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customeridtxt.Text) ||string.IsNullOrWhiteSpace(fullnametxt.Text) || string.IsNullOrWhiteSpace(emailtxt.Text) || string.IsNullOrWhiteSpace(phonenumbertxt.Text) || string.IsNullOrWhiteSpace(addresstxt.Text))
            {
                MessageBox.Show("Please enter the details correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(customeridtxt.Text);
            Customer customer = new Customer(id,fullnametxt.Text ,emailtxt.Text, phonenumbertxt.Text, addresstxt.Text);
            customer.Updateinfo(customer);
            MessageBox.Show("Updated Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            customeridtxt.Clear();
            fullnametxt.Clear();
            emailtxt.Clear();
            phonenumbertxt.Clear();
            addresstxt.Clear();

        }

        private void search_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            if(string.IsNullOrWhiteSpace(fullnametxt.Text) || string.IsNullOrWhiteSpace(phonenumbertxt.Text))
            {
                MessageBox.Show("Please Enter the name and the phone number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dataGridView1.DataSource = customer.SearchCutomer(fullnametxt.Text, phonenumbertxt.Text);
                fullnametxt.Clear();
                phonenumbertxt.Clear();
            }
        }

        private void viewcustomerbtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            dataGridView1.DataSource = customer.LoadCustomer();
        }

        private void viewbookbtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (string.IsNullOrWhiteSpace(customeridtxt.Text))
            {
                MessageBox.Show("Please enter the customer id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int customerid = int.Parse(customeridtxt.Text);
                Booking booking1 = new Booking(customerid);
                dataGridView1.DataSource = booking1.SearchBooking();
            }
        }
    }
}
    