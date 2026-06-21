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
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Desktop\YEAR 2 SEM 2 20252026\DITP 2123  EVENT DRIVEN PROGRAMMING\Project_StagePass\Project_StagePass\Project_StagePass\ConcertTicket.mdf"";Integrated Security=True";


        string selectedCustomerId = "";
     
    
        public Booking()
        {
            InitializeComponent();
           
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
            
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
