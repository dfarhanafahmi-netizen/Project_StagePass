using Project_StagePass;
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
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ConcertTicket.mdf;Integrated Security=True";

        string selectedCustomerId = "";
     
    
        public Booking()
        {
            InitializeComponent();
           
        }

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

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                
            }
        }

        public void RefreshCustomerGrid()
        {
            // Your code here to reload the DataGridView from the database
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
