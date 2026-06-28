using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO; // WAJIB ADA NI
using System.Windows.Forms;

namespace Project_StagePass
{
    public partial class DetailsGoWeeknd : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ConcertTicket.mdf;Integrated Security=True";
        string currentConcertId = "";
        string currentConcertName = "";

        public DetailsGoWeeknd(string concertId)
        {
            InitializeComponent();
            currentConcertId = concertId;
        }

        private void DetailsGoWeeknd_Load(object sender, EventArgs e)
        {
            // Tarik SEMUA data termasuk PosterImage dari database
            using (SqlConnection con = new SqlConnection(connString))
            {
                string query = "SELECT ArtistName, TourName, ConcertDate, PosterImage FROM Concerts WHERE ConcertId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", currentConcertId);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        currentConcertName = reader["TourName"].ToString();
                        lblArtist.Text = reader["ArtistName"].ToString();
                        lblTour.Text = currentConcertName;

                        if (reader["ConcertDate"] != DBNull.Value)
                        {
                            lblDate.Text = Convert.ToDateTime(reader["ConcertDate"]).ToString("d MMMM yyyy");
                        }

                        // MODIFIED: Tarik gambar terus dari database
                        if (reader["PosterImage"] != DBNull.Value)
                        {
                            byte[] imgData = (byte[])reader["PosterImage"];
                            using (MemoryStream ms = new MemoryStream(imgData))
                            {
                                pbPoster.Image = Image.FromStream(ms);
                            }
                        }

                        // Text about kita boleh set default
                        lblAbout.Text = "Experience the magic of " + reader["ArtistName"] + " live on stage!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            Form5 seatForm = new Form5(currentConcertId, currentConcertName);
            if (seatForm.ShowDialog() == DialogResult.OK)
            {
                ProcessBooking(currentConcertId, "PKG01", 100.00m, seatForm.SelectedSeat, seatForm.SelectedZone);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e) => this.Close();

        // (Fungsi ProcessBooking kekal sama seperti asal)
        private void ProcessBooking(string concertId, string packageId, decimal totalAmount, string seat, string zone)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                using (SqlTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        string insertCustomer = @"INSERT INTO Customers (FullName, Email, Price, Chairs) VALUES ('Guest Customer', @Email, 0.00, 'None'); SELECT SCOPE_IDENTITY();";
                        int customerId;
                        using (SqlCommand cmd = new SqlCommand(insertCustomer, con, trans))
                        {
                            cmd.Parameters.AddWithValue("@Email", $"guest_{DateTime.Now.Ticks}@stagepass.com");
                            customerId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string insertBooking = @"INSERT INTO Bookings (CustomerId, ConcertId, TotalAmount, BookingDate, PaymentStatus) VALUES (@CustId, @ConcertId, @Amount, @Date, 'Paid'); SELECT SCOPE_IDENTITY();";
                        int bookingId;
                        using (SqlCommand cmd = new SqlCommand(insertBooking, con, trans))
                        {
                            cmd.Parameters.AddWithValue("@CustId", customerId);
                            cmd.Parameters.AddWithValue("@ConcertId", concertId);
                            cmd.Parameters.AddWithValue("@Amount", totalAmount);
                            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                            bookingId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string insertTicket = @"INSERT INTO Tickets (BookingId, PackageId, SeatNumber, Zone) VALUES (@BookingId, @PackId, @Seat, @Zone)";
                        using (SqlCommand cmd = new SqlCommand(insertTicket, con, trans))
                        {
                            cmd.Parameters.AddWithValue("@BookingId", bookingId);
                            cmd.Parameters.AddWithValue("@PackId", packageId);
                            cmd.Parameters.AddWithValue("@Seat", seat);
                            cmd.Parameters.AddWithValue("@Zone", zone);
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("Booking confirmed!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void lblAbout_TextChanged(object sender, EventArgs e) { }
        private void lblDate_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblTour_Click(object sender, EventArgs e) { }
        private void lblArtist_Click(object sender, EventArgs e) { }
    }
}