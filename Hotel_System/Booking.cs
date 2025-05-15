using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    internal class Booking
    {
        protected int BookingID;
        protected int CustomerID;
        protected int RoomID;
        protected DateTime CheckInDate;
        protected DateTime CheckOutDate;
        public decimal TotalPrice;
        protected string Status;


        public Booking(int CustomerID,int RoomID,DateTime CheckInDate,DateTime CheckOutDate)
        {
            this.CustomerID = CustomerID;
            this.RoomID = RoomID;
            this.CheckInDate = CheckInDate;
            this.CheckOutDate = CheckOutDate;
        }
        public Booking() { }

        public Booking(int BookingID,string Status)
        {
            this.BookingID = BookingID;
            this.Status = Status;
        }

        public Booking(int RoomID,DateTime CheckInDate,DateTime CheckOutDate)
        {
            this.RoomID =RoomID;
            this.CheckInDate = CheckInDate;
            this.CheckOutDate = CheckOutDate;
        }
        public Booking(int CustomerID)
        {
            this.CustomerID = CustomerID;
        }

        public bool CreatingBooking(Booking booking)
        {
            string connectionString = "server=localhost; database=hotelsystemdb; user=root; password=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Step 1: Get room price
                    string priceQuery = "SELECT PricePerNight FROM rooms WHERE RoomID = @id";
                    decimal roomPrice = 0;

                    using (MySqlCommand priceCmd = new MySqlCommand(priceQuery, connection))
                    {
                        priceCmd.Parameters.AddWithValue("@id", booking.RoomID);
                        object result = priceCmd.ExecuteScalar();

                        if (result != null && decimal.TryParse(result.ToString(), out decimal price))
                        {
                            roomPrice = price;
                        }
                        else
                        {
                            MessageBox.Show("Room not found or price is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    // Step 2: Calculate total price
                    double numberOfNights = (booking.CheckOutDate - booking.CheckInDate).TotalDays;

                    if (numberOfNights <= 0)
                    {
                        MessageBox.Show("Check-out date must be after check-in date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    booking.TotalPrice = roomPrice * (decimal)numberOfNights;

                    // Step 3: Insert booking
                    string insertQuery = " INSERT INTO booking  (CustomerID, RoomID, CheckInDate, CheckOutDate, TotalPrice, Status)  VALUES (@customerid, @roomid, @indate, @outdate, @price, 'Pending')";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@customerid", booking.CustomerID);
                        insertCmd.Parameters.AddWithValue("@roomid", booking.RoomID);
                        insertCmd.Parameters.AddWithValue("@indate", booking.CheckInDate);
                        insertCmd.Parameters.AddWithValue("@outdate", booking.CheckOutDate);
                        insertCmd.Parameters.AddWithValue("@price", booking.TotalPrice);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            long insertedBookingId = insertCmd.LastInsertedId;
                            MessageBox.Show($"Booking successful! Your Booking ID is: {insertedBookingId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Failed to create booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show("Database error: " + sqlEx.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public DataTable LoadBookingsForToday()
        {
            string connectionString = "server=localhost; database=hotelsystemdb; user=root; password=;";
            DataTable dataTable = new DataTable();

            // Replace 'booking_date' with the actual column name for booking date
            string query = "SELECT * FROM booking WHERE DATE(CheckInDate) = CURDATE()";

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
            catch (Exception)
            {
                MessageBox.Show("DataBase connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        public bool updateBookings(Booking booking)
        {
            string connectionstring = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = "UPDATE booking SET Status = @status WHERE BookingID = @id";

            using(MySqlConnection connection = new MySqlConnection( connectionstring))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@status", booking.Status);
                        command.Parameters.AddWithValue("@id", booking.BookingID);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("DataBase connection Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }  
            }
        }
        public DataTable LoadAllBooking()
        {
            string connectionString = "server=localhost; database=hotelsystemdb; user=root; password=;";
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM booking";

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

        public DataTable SearchBooking()
        {

            string connectionString = "server=localhost; database=hotelsystemdb; user=root; password=;";
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM booking WHERE CustomerID = @cid";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cid", CustomerID);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving bookings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }
    

        public bool IsRoomAvailable(int roomId, DateTime checkIn, DateTime checkOut)
        {
            string connStr = "server=localhost; database=hotelsystemdb; user=root; password=;";
            string query = @"SELECT COUNT(*) FROM booking
                         WHERE RoomID = @RoomID AND Status = 'Confirmend' 
                         AND (CheckInDate <= @CheckOut AND CheckOutDate >= @CheckIn)";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@RoomID", roomId);
                cmd.Parameters.AddWithValue("@CheckIn", checkIn);
                cmd.Parameters.AddWithValue("@CheckOut", checkOut);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 0;
            }
        }
    }
}
