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
    internal class Payment
    {
        protected int PaymentId;
        protected int BookingId;
        protected int Amount;
        protected DateTime PaymentDate;
        protected string Method;

       public Payment() { }
        
       public Payment(int BookingID,int Amount,string Method)
        {
            this.BookingId = BookingID;
            this.Amount = Amount;
            this.Method = Method;
        }
        public Payment(int BookingID)
        {
            this.BookingId=BookingID;
        }
        public bool Process_Payment(Payment payment)
        {
            string connectionString = "server=localhost; database=hotelsystemdb; user=root; password=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert payment
                        string pquery = "INSERT INTO payments (BookingID, Amount, PaymentDate, Method) VALUES (@bookingid, @amount, @date, @method)";
                        using (MySqlCommand paymentCommand = new MySqlCommand(pquery, connection, transaction))
                        {
                            paymentCommand.Parameters.AddWithValue("@bookingid", payment.BookingId);
                            paymentCommand.Parameters.AddWithValue("@amount", payment.Amount);
                            paymentCommand.Parameters.AddWithValue("@date", DateTime.Now);
                            paymentCommand.Parameters.AddWithValue("@method", payment.Method);
                            paymentCommand.ExecuteNonQuery();
                        }

                        // 2. Update booking status
                        string bquery = "UPDATE booking SET Status = 'Confirmed' WHERE BookingID = @bookingid";
                        using (MySqlCommand statusCommand = new MySqlCommand(bquery, connection, transaction))
                        {
                            statusCommand.Parameters.AddWithValue("@bookingid", payment.BookingId);
                            statusCommand.ExecuteNonQuery();
                        }

                        // 3. Update room availability (you need RoomID for this)
                        string rquery = "UPDATE rooms SET IsAvailable = 'false' WHERE RoomID = (SELECT RoomID FROM booking WHERE BookingID = @bookingid)";
                        using (MySqlCommand rcommand = new MySqlCommand(rquery, connection, transaction))
                        {
                            rcommand.Parameters.AddWithValue("@bookingid", payment.BookingId);
                            rcommand.ExecuteNonQuery();
                        }

                        // Commit if all succeed
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Rollback if anything fails
                        transaction.Rollback();
                        MessageBox.Show("Payment failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public bool Refund(Payment payment)
        {
            string connectionString = "server=localhost; database=hotelsystemdb; user=root; password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Delete payment
                        string deleteQuery = "DELETE FROM payments WHERE BookingID = @id";
                        using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection, transaction))
                        {
                            deleteCommand.Parameters.AddWithValue("@id", BookingId);
                            deleteCommand.ExecuteNonQuery();
                        }

                        // Update booking status to 'Canceled'
                        string updateBooking = "UPDATE booking SET Status = 'Canceled' WHERE BookingID = @bookingid";
                        using (MySqlCommand statusCommand = new MySqlCommand(updateBooking, connection, transaction))
                        {
                            statusCommand.Parameters.AddWithValue("@bookingid", BookingId);
                            statusCommand.ExecuteNonQuery();
                        }

                        // Update room availability
                        string updateRoom = @"
                    UPDATE rooms 
                    SET IsAvailable = 'True' 
                    WHERE RoomID = (SELECT RoomID FROM booking WHERE BookingID = @bookingid)";
                        using (MySqlCommand roomCommand = new MySqlCommand(updateRoom, connection, transaction))
                        {
                            roomCommand.Parameters.AddWithValue("@bookingid", BookingId);
                            roomCommand.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public DataTable Payment_History()
        {
            string connectionString = "server=localhost; database=hotelsystemdb; user=root; password=;";
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM payments";

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


    }
}
