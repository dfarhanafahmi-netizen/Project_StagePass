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
    public partial class ConcertTable : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ConcertTicket.mdf;Integrated Security=True";
        string selectedConcertId = "";
       
        public ConcertTable()
        {
            InitializeComponent();
        }

    
        private void LoadConcertGrid()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                string query = "SELECT ConcertId, ArtistName, TourName, ConcertDate, ConcertTime FROM Concerts";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                dgvConcerts.DataSource = dt;
                
            }
        }

        private void dgvConcerts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvConcerts.Rows[e.RowIndex];

                // Capture the selected Concert ID
                selectedConcertId = row.Cells["ConcertId"].Value.ToString();
                

                
            }

        }

        private void ConcertTable_Load(object sender, EventArgs e)
        {
            LoadConcertGrid();

        }

     
        private void gpbxconcert_Enter(object sender, EventArgs e)
        {

        }

        private void dgvConcerts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        
    }
}
