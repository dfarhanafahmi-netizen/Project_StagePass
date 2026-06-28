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
        // Keeping YOUR original database connection string
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ConcertTicket.mdf;Integrated Security=True";

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

                    // Clean auto-resizing optimization layout
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

        // FRIEND'S ADDITION: Fills the textboxes when a row is clicked
        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBookings.Rows[e.RowIndex];

                txtbxbookingid.Text = row.Cells["BookingId"].Value.ToString();
                txtbxcustid.Text = row.Cells["CustomerId"].Value.ToString();
                txtbxconcertid.Text = row.Cells["ConcertId"].Value.ToString();
                txtbxtotalamount.Text = row.Cells["TotalAmount"].Value.ToString();
                txtbxbookingdate.Text = row.Cells["BookingDate"].Value.ToString();
                txtbxpaymentstatus.Text = row.Cells["PaymentStatus"].Value.ToString();
            }
        }

        // FRIEND'S ADDITION: Clears the textboxes
        private void ClearTextBoxes()
        {
            txtbxbookingid.Clear();
            txtbxcustid.Clear();
            txtbxconcertid.Clear();
            txtbxtotalamount.Clear();
            txtbxbookingdate.Clear();
            txtbxpaymentstatus.Clear();
        }

        // FRIEND'S ADDITION: The Delete Button Logic
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxbookingid.Text))
            {
                MessageBox.Show("Please select a booking to delete.");
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this booking?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    try
                    {
                        con.Open();

                        string query = "DELETE FROM Bookings WHERE BookingId = @BId";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@BId", txtbxbookingid.Text);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Booking deleted successfully.");

                        LoadBookingGrid();
                        ClearTextBoxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting booking: " + ex.Message);
                    }
                }
            }
        }

        // --- Letak function kosong ni supaya Visual Studio tak bising ---
        private void txtbxbookingid_TextChanged(object sender, EventArgs e) { }
        private void txtbxcustid_TextChanged(object sender, EventArgs e) { }
        private void txtbxconcertid_TextChanged(object sender, EventArgs e) { }
        private void txtbxtotalamount_TextChanged(object sender, EventArgs e) { }
        private void txtbxbookingdate_TextChanged(object sender, EventArgs e) { }
        private void txtbxpaymentstatus_TextChanged(object sender, EventArgs e) { }

    }
}