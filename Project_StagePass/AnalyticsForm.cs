using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_StagePass
{
    public partial class AnalyticsForm : Form, IReportable
    {
        public string GetSummary()
        {
            return "Revenue Report for: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        public double CalculateTotalRevenue()
        {

            var allCustomers = DatabaseRecord.LoadAllCustomers();

            return (double)allCustomers.Sum(c => c.Price);
        }
        public AnalyticsForm()
        {
            InitializeComponent();
        }

        

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {

            try
            {
                var allCustomers = DatabaseRecord.LoadAllCustomers();

                // check if list is empty 
                if (allCustomers == null || allCustomers.Count == 0)
                {
                    throw new InvalidDataException("The database returned no customer records!");
                }


                lbltotalrevenue.Text = AnalyticsRecord.CalculateTotalRevenue(allCustomers).ToString("C");

                // Total Tix Sold
                lbltotaltixsold.Text = AnalyticsRecord.CountTotalTickets(allCustomers).ToString();

                // Avg Order Price
                decimal totalRevenue = AnalyticsRecord.CalculateTotalRevenue(allCustomers);
                int totalTickets = AnalyticsRecord.CountTotalTickets(allCustomers);
                lblavgorderprice.Text = (totalRevenue / totalTickets).ToString("C");


                // Empty Orders
                int emptyCount = AnalyticsRecord.GetEmptyOrders(allCustomers).Count;
                lblemptyorders.Text = "" + emptyCount;

                // Unique Emails
                listBoxUniqueEmail.Items.Clear();
                var Emails = AnalyticsRecord.GetUniqueEmails(allCustomers);
                foreach (var email in Emails)
                {
                    listBoxUniqueEmail.Items.Add(email);
                }

            }
            catch (InvalidDataException ex)
            {
                //pop up message
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }


        }

   


        private void btnsearch_Click(object sender, EventArgs e)
        {
            var allCustomers = DatabaseRecord.LoadAllCustomers();
            // Using the text from a TextBox named txtSearch
            var results = AnalyticsRecord.SearchByName(allCustomers, txtbxsearchcust.Text);

            listBoxSearchCustomer.Items.Clear();
            foreach (var res in results)
                listBoxSearchCustomer.Items.Add($"{res.FullName} - {res.Email}");
        }

        private void btnuniqueemail_Click(object sender, EventArgs e)
        {
            var allCustomers = DatabaseRecord.LoadAllCustomers();
            listBoxUniqueEmail.Items.Clear();

            // LINQ query to get unique emails
            var emails = AnalyticsRecord.GetUniqueEmails(allCustomers);
            foreach (var email in emails)
                listBoxUniqueEmail.Items.Add(email);
        }

        private void btnallemails_Click(object sender, EventArgs e)
        {
            var allCustomers = DatabaseRecord.LoadAllCustomers();
            listBoxUniqueEmail.Items.Clear();

            // Display all emails (even duplicates)
            foreach (var cus in allCustomers)
                listBoxUniqueEmail.Items.Add(cus.Email);
        }

        

        private void btnnext_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.ShowDialog();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
