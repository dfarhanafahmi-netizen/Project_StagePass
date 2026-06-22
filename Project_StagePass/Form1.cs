using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_StagePass
{

    public partial class Form1 : Form
    {

        int currentImageIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblh2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.BackColor = Color.Black;
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 0)
            {
                // 2. Move to the next image index
                currentImageIndex++;

                // 3. If we go past the last image, loop back to the first one (0)
                if (currentImageIndex >= imageList1.Images.Count)
                {
                    currentImageIndex = 0;
                }

                // 4. Change the image in your PictureBox
                picBxhomepage.Image = imageList1.Images[currentImageIndex];

                if (currentImageIndex == 0)
                {
                    lblNameArtist.Text = "The Weeknd";
                }
                else if (currentImageIndex == 3)
                {
                    lblNameArtist.Text = "BTS";
                }
            }
        }

        private void btnPrevImage_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 0)
            {
                // 1. Move to the previous image index
                currentImageIndex--;

                // 2. If we go below 0, loop back to the very last image
                if (currentImageIndex < 0)
                {
                    currentImageIndex = imageList1.Images.Count - 1;
                }

                // 3. Update the picture box (Make sure this matches your PictureBox name)
                picBxhomepage.Image = imageList1.Images[currentImageIndex];

                if (currentImageIndex == 0)
                {
                    lblNameArtist.Text = "The Weeknd";
                }
                else if (currentImageIndex == 1)
                {
                    lblNameArtist.Text = "BTS";
                }
            }
        }

        private void btnNextHomepage_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
      
            // 2. Show Form2
            form2.Show();

            // 3. Optional: Hide Form1 so only the new form is visible
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }
    }
}
