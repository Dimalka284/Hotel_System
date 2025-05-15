using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_System
{
    internal class Customer
    {
        protected int CustomerId;
        protected string FullName;
        protected string Email;
        protected string PhoneNumber;
        protected string Address;

        public Customer() { }

        public Customer(string FullName, string Email, string PhoneNumber, string Address)
        {
            this.FullName = FullName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
        }

        public Customer(int CustomerId,string FullName,string Email, string PhoneNumber, string Address)
        {
            this.CustomerId = CustomerId;
            this.FullName = FullName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
        }
        public bool Register(Customer customer)
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "INSERT INTO customers(FullName,Email,Phone,Address)VALUES(@name,@email,@pnumber,@address)";

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", customer.FullName);
                        command.Parameters.AddWithValue("@email", customer.Email);
                        command.Parameters.AddWithValue("@pnumber", customer.PhoneNumber);
                        command.Parameters.AddWithValue("@address", customer.Address);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception)
                { 
                    MessageBox.Show("Failed to register","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

        }

        public bool Updateinfo(Customer customer)
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "UPDATE customers SET FullName = @name,Email = @email,Phone = @pnumber,Address = @address WHERE CustomerID = @id";

            using (MySqlConnection connection  = new MySqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id",customer.CustomerId);
                        command.Parameters.AddWithValue("@name",customer.FullName);
                        command.Parameters.AddWithValue("@email", customer.Email);
                        command.Parameters.AddWithValue("@pnumber", customer.PhoneNumber);
                        command.Parameters.AddWithValue("@address", customer.Address);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("failed to register", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public DataTable SearchCutomer(string Name,string PhoneNo)
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "SELECT * FROM customers WHERE FullName = @name AND Phone = @phoneno";
            DataTable table = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@phoneno",PhoneNo);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }
        public DataTable LoadCustomer()
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "SELECT * FROM customers";
            DataTable table = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }
        public DataTable SearchBooking(int CustomerID)
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "SELECT * FROM booking WHERE CustomerID = @id";
            DataTable table = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id",CustomerID);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }
    }
}
