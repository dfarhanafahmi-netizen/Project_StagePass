using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetailsGo
{
    public partial class Form3 : Form
    {
        public string CustomerName => textBoxCustomerName.Text;
        public string PhoneNumber => textBoxPhoneNumber.Text;

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxCustomerName, "");
            if(textBoxCustomerName.Text == "")
            {
                errorProvider1.SetError(textBoxCustomerName, "Please enter your name");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
