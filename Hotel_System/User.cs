using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    internal class User
    {
        protected int UserId;
        protected string UserName;
        protected string Password;
        protected string Role;

        public User(string UserName,string Password,string Role)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Role = Role;
        }
        public User(int UserID)
        {
            this.UserId = UserID;

        }
        public User(int UserId,string UserName,string Password, string Role)
        {
            this.UserId = UserId;
            this.UserName = UserName;
            this.Password = Password;
            this.Role = Role;
        }
        public User() { }

        public bool Adduser(User user)
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "INSERT INTO users(Username,Password,Role) VALUES (@name,@password,@role)";

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", user.UserName);
                        command.Parameters.AddWithValue("@password", user.Password);
                        command.Parameters.AddWithValue("@role", user.Role);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"error: {ex.Message}");
                    return false;
                }
            }
        }

        public bool Deleteuser(User User)
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "DELETE FROM users WHERE UserId = @id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", User.UserId);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show($"Error deleting user","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

        }

        public bool UpdateUser(User User)
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "UPDATE users SET Username = @name,Password = @password,Role = @role WHERE UserID = @userid";

            using(MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userid", User.UserId);
                        command.Parameters.AddWithValue("@name", User.UserName);
                        command.Parameters.AddWithValue("@password", User.Password);
                        command.Parameters.AddWithValue("@role", User.Role);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"An Error Occured","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool Validlogin(string username, string password)
        {
           string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "SELECT COUNT(*) FROM users WHERE Username = @username AND Password = @password";

            using(MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());//SQL query and returns a single value
                        return count > 0;//If there is a record it should be 1 and if not it should be zero.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred:{ex.Message}","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }



        public DataTable LoadAllUser()
        {
            string connectionString = "server=localhost; database=hotelsystemdb; user=root; password=;";
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM users";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the error
                throw new Exception($"Database error: {ex.Message}");
            }

            return dataTable;
        }
        public DataTable SearchUser(int UserId)
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM users WHERE UserID = @id";

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", UserId);
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);

                    }

                }
            }
            return dataTable;
        }

    }
}
