using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    internal class Rooms
    {
        protected int RoomID;
        protected string RoomNumber;
        protected string RoomType;
        protected int PricePerNight;
        protected bool IsAvailable;

        public Rooms() { }

        public Rooms(int RoomID)
        {
            this.RoomID = RoomID;
        }
        public Rooms(string roomNumber, string roomType, int pricePerNight, bool isAvailable)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
        }
        public Rooms(int RoomID,string RoomNumber,string RoomType, int PricePerNight,bool isAvailable)
        {
            this.RoomID=RoomID;
            this.RoomNumber=RoomNumber;
            this.RoomType=RoomType;
            this.PricePerNight=PricePerNight;
            this.IsAvailable = isAvailable;
        }
        public bool Add_Rooms(Rooms rooms)
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "INSERT INTO rooms (RoomNumber,RoomType,PricePerNight,IsAvailable) VALUES (@number,@type,@price,@Isavailable)";

            using (MySqlConnection connection = new MySqlConnection(connectionstring)) 
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@number",rooms.RoomNumber);
                        command.Parameters.AddWithValue("@type", rooms.RoomType);
                        command.Parameters.AddWithValue("@price", rooms.PricePerNight);
                        command.Parameters.AddWithValue("@Isavailable", rooms.IsAvailable);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show($"Error Adding rooms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
        }
        public bool edit_rooms(Rooms room)
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "UPDATE rooms SET RoomNumber = @number,RoomType = @type,PricePerNight = @price,IsAvailable = @isavailable WHERE RoomID = @id";

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", room.RoomID);
                        command.Parameters.AddWithValue("@number", room.RoomNumber);
                        command.Parameters.AddWithValue("@type", room.RoomType);
                        command.Parameters.AddWithValue("@price", room.PricePerNight);
                        command.Parameters.AddWithValue("@isavailable", room.IsAvailable);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public bool removeroom(Rooms room)
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "DELETE FROM rooms WHERE RoomID = @id";

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id",room.RoomID);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public DataTable LoadRooms()
        {
            string connectionString = "server=localhost; database=hotelsystemdb; user=root; password=;";
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM rooms";

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
        public DataTable Searchrooms(string Roomtype)
        {
            string connectionstring ="server=localhost; database=hotelsystemdb; user=root; password=;";
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM rooms WHERE RoomType = @type";

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@type",Roomtype);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
    }
}
