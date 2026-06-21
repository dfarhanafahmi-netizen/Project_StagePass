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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            AdminLogin formlogin = new AdminLogin();

            if (formlogin.ShowDialog() == DialogResult.OK)
            {
                // Only open the Analytics if login was successful
                this.Hide();
                AnalyticsForm adminDash = new AnalyticsForm();
                adminDash.ShowDialog();

                this.Show();
            }
            
            
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
           
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
