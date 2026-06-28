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
using System.Xml.Linq;

namespace Project_StagePass
{
    public partial class Booking : Form
    {
        // Keeping YOUR original database connection string
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ConcertTicket.mdf;Integrated Security=True";

        string selectedCustomerId = "";

        public Booking()
        {
            InitializeComponent();
        }

        // Keeping your ID generator function
        private string GetNextCustomId(string tableName, string columnName, string prefix, string format)
        {
            string nextId = prefix + (1.ToString(format));
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

        public void LoadAllGrids()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                string query = "SELECT CustomerId, FullName, Email, Price, Chairs FROM Customers";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                try
                {
                    con.Open();
                    da.Fill(dt);
                    dgvCustomers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading grid data: " + ex.Message);
                }
            }
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            LoadAllGrids();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // FRIEND'S ADDITION: Fills the textboxes when a row is clicked
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                txtbxcustid.Text = row.Cells["CustomerId"].Value.ToString();
                txtbxname.Text = row.Cells["FullName"].Value.ToString();
                txtbxemail.Text = row.Cells["Email"].Value.ToString();
                txtbxprice.Text = row.Cells["Price"].Value.ToString();
                txtbxseat.Text = row.Cells["Chairs"].Value.ToString();
            }
        }

        public void RefreshCustomerGrid()
        {
            // Your code here to reload the DataGridView from the database
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        // FRIEND'S ADDITION: The Delete Button Logic
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxcustid.Text))
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    try
                    {
                        con.Open();

                        // Delete from Bookings Table
                        string deleteBooking = "DELETE FROM Bookings WHERE CustomerId = @Id";
                        using (SqlCommand cmd = new SqlCommand(deleteBooking, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", txtbxcustid.Text);
                            cmd.ExecuteNonQuery();
                        }

                        // Delete from Customers Table
                        string deleteCustomer = "DELETE FROM Customers WHERE CustomerId = @Id";
                        using (SqlCommand cmd = new SqlCommand(deleteCustomer, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", txtbxcustid.Text);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Record deleted successfully.");
                        LoadAllGrids();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                }
            }
        }

        // --- Letak function kosong ni supaya Visual Studio tak bising ---
        private void txtbxcustid_TextChanged(object sender, EventArgs e) { }
        private void txtbxname_TextChanged(object sender, EventArgs e) { }
        private void txtbxemail_TextChanged(object sender, EventArgs e) { }
        private void txtbxprice_TextChanged(object sender, EventArgs e) { }
        private void txtbxseat_TextChanged(object sender, EventArgs e) { }

    }
}