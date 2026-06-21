using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_StagePass
{
    public partial class DetailsGoLaufey : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Desktop\YEAR 2 SEM 2 20252026\DITP 2123  EVENT DRIVEN PROGRAMMING\Project_StagePass\Project_StagePass\Project_StagePass\ConcertTicket.mdf"";Integrated Security=True";
        public DetailsGoLaufey()
        {
            InitializeComponent();
        }

        private string GetNextCustomId(string tableName, string columnName, string prefix, string format)
        {
            string nextId = prefix + (1.ToString(format)); // Fallback default if table is totally empty (e.g., B01)
            string query = $"SELECT TOP 1 {columnName} FROM {tableName} ORDER BY {columnName} DESC";

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            string highestId = result.ToString();
                            string numericPartStr = highestId.Substring(prefix.Length);
                            if (int.TryParse(numericPartStr, out int currentNumber))
                            {
                                int nextNumber = currentNumber + 1;
                                nextId = prefix + nextNumber.ToString(format);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ID Generation error: " + ex.Message);
                    }
                }
            }
            return nextId;
        }
        private void labelConcertName_Click(object sender, EventArgs e)
        {

        }

        private void ProcessBooking(string concertId, string packageId, decimal totalAmount, string seat, string zone)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    using (SqlTransaction trans = con.BeginTransaction())
                    {
                        // 1. Insert Customer - Let the database auto-generate ID
                        string insertCustomer = @"INSERT INTO Customers (FullName, Email, Price, Chairs) 
                                          VALUES ('Guest Customer', @Email, 0.00, 'None'); 
                                          SELECT SCOPE_IDENTITY();";
                        int customerId;
                        using (SqlCommand cmd = new SqlCommand(insertCustomer, con, trans))
                        {
                            cmd.Parameters.AddWithValue("@Email", $"guest_{DateTime.Now.Ticks}@stagepass.com");
                            customerId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2. Insert Booking - VenueId matches your database column name
                        string insertBooking = @"INSERT INTO Bookings (CustomerId, ConcertId,  TotalAmount, BookingDate, PaymentStatus) 
                                         VALUES (@CustId, @ConcertId,  @Amount, @Date, 'Paid'); 
                                         SELECT SCOPE_IDENTITY();";

                        int bookingId;
                        using (SqlCommand cmd = new SqlCommand(insertBooking, con, trans))
                        {
                            cmd.Parameters.AddWithValue("@CustId", customerId);
                            cmd.Parameters.AddWithValue("@ConcertId", concertId);
                            
                            cmd.Parameters.AddWithValue("@Amount", totalAmount);
                            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                            bookingId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 3. Insert Ticket - Links Booking to Package
                        string insertTicket = @"INSERT INTO Tickets (BookingId, PackageId, SeatNumber, Zone) 
                                        VALUES (@BookingId, @PackId, @Seat, @Zone)";
                        using (SqlCommand cmd = new SqlCommand(insertTicket, con, trans))
                        {
                            cmd.Parameters.AddWithValue("@BookingId", bookingId);
                            cmd.Parameters.AddWithValue("@PackId", packageId);
                            cmd.Parameters.AddWithValue("@Seat", seat);
                            cmd.Parameters.AddWithValue("@Zone", zone);
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit(); // Finalizes all inserts
                    }
                    MessageBox.Show("Booking confirmed successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Transaction failed: " + ex.Message);
                }
            }
        }
        private void buttonBook_Click(object sender, EventArgs e)
        {
            Form5 seatForm = new Form5("CON01", "Laufey Live in KL"); // Pass Laufey specific ID/Name
            seatForm.ShowDialog();
            this.Hide();

        }

        private void buttonBack_Click(object sender, EventArgs e) => this.Close();

        private void DetailsGoLaufey_Load(object sender, EventArgs e)
        {

        }
    }
}
