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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void buttonloginadmin_Click(object sender, EventArgs e)
        {
            if (SecurityHelper.Authenticate(txtbxusername.Text, txtbxpassword.Text))
            {
                this.DialogResult = DialogResult.OK; // Signals to MainPage that login was successful
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
                this.DialogResult = DialogResult.None; // Keeps the form open
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
