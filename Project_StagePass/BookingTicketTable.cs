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
    public partial class BookingTicketTable : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Desktop\YEAR 2 SEM 2 20252026\DITP 2123  EVENT DRIVEN PROGRAMMING\Project_StagePass\Project_StagePass\Project_StagePass\ConcertTicket.mdf"";Integrated Security=True";
        public BookingTicketTable()
        {
            InitializeComponent();
        }

        private void BookingTicketTable_Load(object sender, EventArgs e)
        {
            LoadBookingGrid();
        }

        private void LoadBookingGrid()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                // Pulls all the columns out from your Bookings table schema
                string query = "SELECT BookingId, CustomerId, ConcertId, TotalAmount, BookingDate, PaymentStatus FROM Bookings";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                try
                {
                    con.Open();
                    da.Fill(dt);

                    // Binds the database records visually to your DataGridView
                    dgvBookings.DataSource = dt;

                   
                    dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Booking records: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
