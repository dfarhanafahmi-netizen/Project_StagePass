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
    public partial class PaymentMethod : Form
    {
        public string TotalPriceToDisplay { get; set; }
        public string eventName { get; set; }
        public string CustomerName { get; set; }
       
        public string paymentMethod { get; set; }
        public decimal subTotal { get; set; }
        public string CustomerEmail { get; set; }
        public int TicketCount { get; set; }
        public PaymentMethod()
        {
            InitializeComponent();
        }

        private void PaymentMethod_Load(object sender, EventArgs e)
        {
           
        }

     

        private void button1_Click(object sender, EventArgs e)
        {

            decimal price = decimal.Parse(TotalPriceToDisplay.Replace("RM", "").Replace(",", "").Trim());
            receipt form3 = new receipt(eventName, CustomerName, GetSelectedPayment(), price, this.TicketCount);

            form3.CustomerEmail = this.CustomerEmail;

            form3.DisplayData();
            form3.ShowDialog();

        }

        private void cbTerms_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbTerms.Checked)
            {
                MessageBox.Show("You must agree to the Terms and Conditions before proceeding.");
                return;
            }

          
        }

        private string GetSelectedPayment()
        {
            if (rbFPX.Checked) return "FPX Internet Banking";
            if (rbCARD.Checked) return "Credit/Debit Card";
            if (rbTNG.Checked) return "Touch 'n Go E-Wallet";
            return "None";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbPayment_Enter(object sender, EventArgs e)
        {

        }

        private void btnnuy_Click(object sender, EventArgs e)
        {
            string method = GetSelectedPayment();
            if (method == "None") { MessageBox.Show("Please select a payment method."); return; }
            if (!cbTerms.Checked) { MessageBox.Show("You must agree to the terms and conditions before proceeding."); return; }

            decimal parsedPrice;

            if(decimal.TryParse(TotalPriceToDisplay.Replace("RM","").Replace(",", "").Trim(), out parsedPrice))
            {
                this.subTotal = parsedPrice;
            }

            MessageBox.Show("You selected: " + method + "\nTotal: " + TotalPriceToDisplay);
        

            receipt form3 = new receipt (eventName,CustomerName, method, this.subTotal,this.TicketCount);
           
            form3.EventName = this.eventName;
            form3.CustomerName = this.CustomerName;
            form3.CustomerEmail = this.CustomerEmail;
            form3.ReceiptDate = DateTime.Now.ToString("dd/MM/yyyy");
            form3.ReceiptTime = DateTime.Now.ToString("HH:mm:ss");
            form3.PaymentMethod = method;
            form3.TotalPrice = this.subTotal;
            form3.TicketCount = this.TicketCount;


            form3.DisplayData();
            form3.ShowDialog();

            this.Close();

        }   
    }
}
