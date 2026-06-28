using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO; // WAJIB TAMBAH NI UNTUK BACA GAMBAR
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

        // Variable untuk pegang data gambar sementara sebelum di-save
        byte[] imageBytes = null;

        public ConcertTable()
        {
            InitializeComponent();
        }

        private void LoadConcertGrid()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                // Tarik sekali kolum PosterImage dari database
                string query = "SELECT ConcertId, ArtistName, TourName, ConcertDate, ConcertTime, PosterImage FROM Concerts";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvConcerts.DataSource = dt;
            }
        }

        // FUNGSI BARU: Butang untuk cari gambar dalam laptop
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"; // Benarkan format gambar je

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Tunjuk preview gambar kat PictureBox
                pbPosterUpload.Image = Image.FromFile(ofd.FileName);

                // Tukar gambar jadi format Byte (supaya boleh sumbat masuk database)
                using (MemoryStream ms = new MemoryStream())
                {
                    // Resize gambar kepada lebar 300px (tinggi akan ikut ratio)
                    int maxWidth = 300;
                    int height = (int)(pbPosterUpload.Image.Height * ((float)maxWidth / pbPosterUpload.Image.Width));

                    Bitmap resizedImage = new Bitmap(pbPosterUpload.Image, new Size(maxWidth, height));
                    resizedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Save as Jpeg (lebih ringan)
                    imageBytes = ms.ToArray();
                }
            }
        }

        private void dgvConcerts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvConcerts.Rows[e.RowIndex];

                selectedConcertId = row.Cells["ConcertId"].Value.ToString();

                txtbxconcertid.Text = row.Cells["ConcertId"].Value?.ToString();
                txtbxartistname.Text = row.Cells["ArtistName"].Value?.ToString();
                txtbxtourname.Text = row.Cells["TourName"].Value?.ToString();

                if (row.Cells["ConcertDate"].Value != null && DateTime.TryParse(row.Cells["ConcertDate"].Value.ToString(), out DateTime dateValue))
                {
                    dtpdate.Value = dateValue;
                }

                if (row.Cells["ConcertTime"].Value != null && DateTime.TryParse(row.Cells["ConcertTime"].Value.ToString(), out DateTime timeValue))
                {
                    dtptime.Value = timeValue;
                }

                // FUNGSI BARU: Paparkan balik gambar bila admin klik list kat grid
                if (row.Cells["PosterImage"].Value != DBNull.Value)
                {
                    byte[] imgData = (byte[])row.Cells["PosterImage"].Value;
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        pbPosterUpload.Image = Image.FromStream(ms);
                        imageBytes = imgData; // Simpan dalam memori in case nak update benda lain
                    }
                }
                else
                {
                    pbPosterUpload.Image = null; // Kosongkan kalau concert tu takde gambar
                    imageBytes = null;
                }
            }
        }

        private void ConcertTable_Load(object sender, EventArgs e)
        {
            LoadConcertGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                // UPDATE KOD: Masukkan parameter PosterImage
                string query = "INSERT INTO Concerts (ConcertId, ArtistName, TourName, ConcertDate, ConcertTime, PosterImage) VALUES (@id, @name, @tour, @date, @time, @image)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtbxconcertid.Text);
                cmd.Parameters.AddWithValue("@name", txtbxartistname.Text);
                cmd.Parameters.AddWithValue("@tour", txtbxtourname.Text);
                cmd.Parameters.AddWithValue("@date", dtpdate.Value.Date);
                cmd.Parameters.AddWithValue("@time", dtptime.Value.TimeOfDay);

                // Masukkan gambar kalau ada, kalau takde hantar Null
                cmd.Parameters.AddWithValue("@image", imageBytes ?? (object)DBNull.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                LoadConcertGrid();
                MessageBox.Show("Concert added successfully!");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                // UPDATE KOD: Kemaskini parameter PosterImage
                string query = @"UPDATE Concerts SET ArtistName=@name, TourName=@tour, ConcertDate=@date, ConcertTime=@time, PosterImage=@image WHERE ConcertId=@id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", txtbxconcertid.Text);
                    cmd.Parameters.AddWithValue("@name", txtbxartistname.Text);
                    cmd.Parameters.AddWithValue("@tour", txtbxtourname.Text);
                    cmd.Parameters.AddWithValue("@date", dtpdate.Value.Date);
                    cmd.Parameters.AddWithValue("@time", dtptime.Value.TimeOfDay);

                    cmd.Parameters.AddWithValue("@image", imageBytes ?? (object)DBNull.Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadConcertGrid();
                MessageBox.Show("Concert updated successfully!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                string query = "DELETE FROM Concerts WHERE ConcertId=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtbxconcertid.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                LoadConcertGrid();

                // Kosongkan gambar lepas delete
                pbPosterUpload.Image = null;
                imageBytes = null;
                MessageBox.Show("Concert deleted successfully!");
            }
        }

        // --- Event handlers kosong ---
        private void txtbxconcertid_TextChanged(object sender, EventArgs e) { }
        private void txtbxartistname_TextChanged(object sender, EventArgs e) { }
        private void txtbxtourname_TextChanged(object sender, EventArgs e) { }
        private void dtpdate_ValueChanged(object sender, EventArgs e) { }
        private void dtptime_ValueChanged(object sender, EventArgs e) { }
        private void gpbxconcert_Enter(object sender, EventArgs e) { }
        private void dgvConcerts_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void pbPosterUpload_Click(object sender, EventArgs e) { }
    }
}