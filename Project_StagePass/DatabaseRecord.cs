using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_StagePass
{

    public class DatabaseRecord
    {

        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ConcertTicket.mdf;Integrated Security=True";

        public static void InitializeDatabase()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ConcertTicket.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                }
                catch (Exception ex)
                {
                    // The error message here is the key to fixing this
                    MessageBox.Show("Connection failed. Error details: " + ex.Message);
                }
            }
        }

        public static DataTable LoadBookingReport()
        {
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(connectionString))
            {
                // This query "joins" the three tables to show you the full picture
                string sql = @"SELECT C.FullName, Con.ConcertName, B.BookingDate 
                       FROM Bookings B
                       JOIN Customers C ON B.CustomerId = C.CustomerId
                       JOIN Concerts Con ON B.ConcertId = Con.ConcertId";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    dt.Load(cmd.ExecuteReader());
                }
            }
            return dt;
        }

        public static void SaveBooking(Customer cus, int customerId, string concertId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Bookings (CustomerId, ConcertId, TotalAmount, BookingDate, PaymentStatus) 
                         VALUES (@CusId, @ConcertId, @Amount, GETDATE(), 'Paid')";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CusId", customerId);
                    cmd.Parameters.AddWithValue("@ConcertId", concertId);
                    cmd.Parameters.AddWithValue("@Amount", cus.Price);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveCustomer(Customer cus, string concertId)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Create the chair string once
                    string chairString = string.Join(";", cus.Chairs.Select(c => $"{c.Item1},{c.Item2}"));

                    string query = @"INSERT INTO Customers (FullName, Email, Price, Chairs) 
                             VALUES (@Name, @Email, @Price, @Chairs);

                    SELECT SCOPE_IDENTITY(); ";

                    int newCustomerId;

                    using (var cmd = new SqlCommand(query, conn)) // Fixed: used 'query' variable
                    {
                        cmd.Parameters.AddWithValue("@Name", cus.FullName); // Names match placeholders
                        cmd.Parameters.AddWithValue("@Email", cus.Email);
                        cmd.Parameters.AddWithValue("@Price", cus.Price);
                        cmd.Parameters.AddWithValue("@Chairs", chairString);

                        newCustomerId = Convert.ToInt32(cmd.ExecuteScalar());

                    }

                    SaveBooking(cus, newCustomerId, concertId);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Save Error: " + ex.Message);
            }
        }

        public static List<Customer> LoadAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT CustomerId, FullName, Email, Price, Chairs FROM Customers";
                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())

                { 
                    {
                        while (reader.Read())
                        {
                            string chairData = reader["Chairs"] != DBNull.Value ? reader["Chairs"].ToString() : "";
                            var chairList = new List<(int, int)>();

                            if (!string.IsNullOrEmpty(chairData))
                            {
                                foreach (var item in chairData.Split(';'))
                                {
                                    var parts = item.Split(',');
                                    if (parts.Length == 2)
                                    {
                                        chairList.Add((int.Parse(parts[0]), int.Parse(parts[1])));
                                    }
                                }
                            }
                            // Create a new Customer object for every row in the table
                            customers.Add(new Customer
                            {
                                FullName = reader["FullName"] != DBNull.Value ? reader["FullName"].ToString() : "",

                                Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "",
                                Price = reader["Price"] != DBNull.Value ? Convert.ToDouble(reader["Price"]) : 0.0,
                                Chairs = chairList
                            });
                        }
                    }
                }

                return customers;
            }
        }
    }
}



