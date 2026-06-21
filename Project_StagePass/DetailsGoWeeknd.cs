using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_StagePass
{
    public partial class DetailsGoWeeknd : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Desktop\YEAR 2 SEM 2 20252026\DITP 2123  EVENT DRIVEN PROGRAMMING\Project_StagePass\Project_StagePass\Project_StagePass\ConcertTicket.mdf"";Integrated Security=True";
        public DetailsGoWeeknd()
        {
            InitializeComponent();
        }

       

        private void ProcessBooking(string concertId, string packageId, decimal totalAmount, string seat, string zone)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                                
                    con.Open();
                    using (SqlTransaction trans = con.BeginTransaction())
                    try
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
                                         VALUES (@CustId, @ConcertId, @Amount, @Date, 'Paid'); 
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

                        string updateConcert = "UPDATE Concerts SET CustomerId = @NewCustId WHERE ConcertId = @ConcertId";
                        using (SqlCommand cmd = new SqlCommand(updateConcert, con, trans))
                        {
                            cmd.Parameters.AddWithValue("@NewCustId", customerId);
                            cmd.Parameters.AddWithValue("@ConcertId", concertId);

                           
                            cmd.ExecuteNonQuery();
                        }


                        trans.Commit(); // Finalizes all inserts
                        MessageBox.Show("Booking confirmed!");
                        this.Close();
                    }
                    catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error: " + ex.Message);

                } } } 
        
                   
            
        

        private void buttonBook_Click(object sender, EventArgs e)
        {
            // Pass the Concert ID and Name to Form5
            Form5 seatForm = new Form5("CON03", "After Hours Till Dawn");



            // Only process if the user clicks "Confirm" or similar in Form5
            if (seatForm.ShowDialog() == DialogResult.OK)
            {
                ProcessBooking("CON03", "PKG01", 100.00m, seatForm.SelectedSeat, seatForm.SelectedZone);
            }
        
        
        }

        private void buttonBack_Click(object sender, EventArgs e) => this.Close();

        private void DetailsGoWeeknd_Load(object sender, EventArgs e)
        {

        }
    }
}
