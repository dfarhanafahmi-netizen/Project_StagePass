using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Project_StagePass
{
    public partial class receipt : Form
    {
        public string CustomerName { get; set; }
        public string EventName { get; set; }
        public string PaymentMethod { get; set; }
        public decimal TotalPrice { get; set; }
        public string CustomerEmail { get; set; }
        public string ReceiptDate { get; set; }
        public string ReceiptTime { get; set; }
        public int TicketCount { get; set; }

        public receipt(string eventName, string customerName, string paymentMethod, decimal subTotal, int ticketCount)
        {
            
            InitializeComponent();

            // assign values from payment and customer details to labels
            lbleventname.Text = eventName;
            lblcustname.Text = customerName;   
            lblsubtotal.Text = subTotal.ToString("C");
            lblNoofTicket.Text = ticketCount.ToString();
            lblemail.Text = CustomerEmail;
            lblpaymentmethod.Text = paymentMethod;
            lbldate.Text = ReceiptDate;
            lbltime.Text = ReceiptTime;

            decimal tax = subTotal * 0.06m;
            lbltaxrate.Text = tax.ToString("C");
            lbltotalamount.Text = (subTotal + tax).ToString("C");
        }

        public void DisplayData()
        {
            lbleventname.Text = EventName;
            lblcustname.Text = CustomerName;
            lbldate.Text = ReceiptDate;
            lbltime.Text = ReceiptTime; 
            lblemail.Text = CustomerEmail;
            lblpaymentmethod.Text = PaymentMethod;
            lblsubtotal.Text = TotalPrice.ToString("C");
            lblNoofTicket.Text = TicketCount.ToString();  

            decimal tax = TotalPrice * 0.06m;
            lbltaxrate.Text = tax.ToString("C");
            lbltotalamount.Text = (TotalPrice + tax).ToString("C");

        }



        private void Receipt_Load(object sender, EventArgs e)
        {
            

        }

        private void lbleventname_Click(object sender, EventArgs e)
        {

        }
    }
}
