using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_StagePass
{
    public partial class Form6 : Form
    {

        public string CustomerName => textBoxCustomerName.Text;
        public string CustomerEmail { get; set; }
        
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            string emailFormat  = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool isValidEmail = Regex.IsMatch(txtbxemail.Text, emailFormat );

            if (string.IsNullOrWhiteSpace(textBoxCustomerName.Text))
            {
                errorProvider1.SetError(textBoxCustomerName, "Please fill in the name.");

            }
            else if (!isValidEmail)
            {
                MessageBox.Show("Please enter a valid email address ( must include @).");
                errorProvider1.SetError(txtbxemail, " Please enter valid email address (must contain @).");
            }else
            {
                this.CustomerEmail = txtbxemail.Text;
                DialogResult = DialogResult.OK;
            }
           

                
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
