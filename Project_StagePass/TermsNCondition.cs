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
    public partial class TermsNCondition : Form
    {
        public TermsNCondition()
        {
            InitializeComponent();
            txtbxtnc.Text = @"TERMS AND CONDITIONS
           1. Booking Confirmation: All bookings are final once payment is confirmed.
           2. No Refunds: Tickets sold are non-refundable under any circumstances.
           3. Event Changes: StagePass reserves the right to change event times or venues.
           4. Privacy: Your email and personal details will only be used for ticket processing.";
        }

        private void txtbxtnc_TextChanged(object sender, EventArgs e)
        {

        }

        private void TermsNCondition_Load(object sender, EventArgs e)
        {

        }
    }
}