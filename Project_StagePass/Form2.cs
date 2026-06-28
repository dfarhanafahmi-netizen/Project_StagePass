using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO; // WAJIB ADA NI
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_StagePass
{
    public partial class Form2 : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ConcertTicket.mdf;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PopulateUpcomingConcerts();
        }

        private void btnBackUC_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)Application.OpenForms["Form1"];
            if (mainForm != null) { mainForm.Show(); this.Close(); }
            else { Form1 newMainForm = new Form1(); newMainForm.Show(); this.Close(); }
        }

        private void PopulateUpcomingConcerts()
        {
            flpconcert.Controls.Clear();

            using (SqlConnection con = new SqlConnection(connString))
            {
                // Tarik PosterImage sekali
                string query = "SELECT ConcertId, ArtistName, TourName, ConcertDate, PosterImage FROM Concerts";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string concertId = reader["ConcertId"].ToString();
                        string artistName = reader["ArtistName"].ToString();
                        string tourName = reader["TourName"].ToString();

                        string dateStr = reader["ConcertDate"] != DBNull.Value
                            ? Convert.ToDateTime(reader["ConcertDate"]).ToString("d MMM yyyy")
                            : "";

                        GroupBox card = new GroupBox();
                        card.Text = $"  {artistName}  ";
                        card.ForeColor = Color.White;
                        card.Size = new Size(220, 360);
                        card.Margin = new Padding(15);
                        card.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                        PictureBox pb = new PictureBox();
                        pb.Size = new Size(190, 130);
                        pb.Location = new Point(15, 25);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.FixedSingle;

                        // LOGIK GAMBAR DARI DATABASE
                        if (reader["PosterImage"] != DBNull.Value)
                        {
                            byte[] imgData = (byte[])reader["PosterImage"];
                            using (MemoryStream ms = new MemoryStream(imgData))
                            {
                                pb.Image = Image.FromStream(ms);
                            }
                        }
                        card.Controls.Add(pb);

                        Label lblTour = new Label();
                        lblTour.Text = tourName;
                        lblTour.ForeColor = Color.Khaki;
                        lblTour.Location = new Point(15, 175);
                        lblTour.Size = new Size(190, 40);
                        card.Controls.Add(lblTour);

                        Label lblDate = new Label();
                        lblDate.Text = dateStr;
                        lblDate.ForeColor = Color.LightGray;
                        lblDate.Location = new Point(15, 225);
                        card.Controls.Add(lblDate);

                        Button btnGo = new Button();
                        btnGo.Text = "Go";
                        btnGo.ForeColor = Color.Black;
                        btnGo.BackColor = Color.LightGray;
                        btnGo.Size = new Size(90, 30);
                        btnGo.Location = new Point(65, 300);
                        btnGo.Tag = concertId;
                        btnGo.Click += BtnGo_Click;
                        card.Controls.Add(btnGo);

                        flpconcert.Controls.Add(card);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                DetailsGoWeeknd detailsForm = new DetailsGoWeeknd(clickedButton.Tag.ToString());
                detailsForm.ShowDialog();
            }
        }

        private void lblComingSoon_Click(object sender, EventArgs e) { }
        private void flpconcert_Paint(object sender, PaintEventArgs e) { }
    }
}