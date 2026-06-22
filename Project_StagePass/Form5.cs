using System;
using System.Collections;
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
    public partial class Form5 : Form
    {
        public string SelectedConcertId { get; set; }
        //Receive event name from DetailsGo form
        public string SelectedEventName { get; set; }

        public string SelectedSeat { get; set; }
        public string SelectedZone { get; set; }



        //Declare customer list
        List<Customer> ListCustomer = new List<Customer>();
        public Form5(string concertId, string eventName)
        {

            InitializeComponent();
            SelectedConcertId = concertId;
            SelectedEventName = eventName;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
            
        }

        private void DrawChairs(TableLayoutPanel panel)
        {
            int chair = 1;
            for (int i = 0; i < panel.RowCount; i++)
                for (int j = 0; j < panel.ColumnCount; j++)
                {
                    Label lblChair = new Label();
                    lblChair.Text = chair++.ToString();
                    lblChair.AutoSize = false;
                    lblChair.Dock = DockStyle.Fill;
                    lblChair.TextAlign = ContentAlignment.MiddleCenter;
                    lblChair.BackColor = Color.LightGray;
                    lblChair.BorderStyle = BorderStyle.FixedSingle;
                    lblChair.Click += LblChair_Click;
                    panel.Controls.Add(lblChair, j, i);
                }
        }

        private void LblChair_Click(object sender, EventArgs e)
        {
            Label lblChair = sender as Label;
            if (lblChair.BackColor == Color.LightGray) //customer select
            {
                lblChair.BackColor = Color.SkyBlue;
            }
            else if (lblChair.BackColor == Color.SkyBlue) //customer deselect
            {
                lblChair.BackColor = Color.LightGray;
            }
            else if (lblChair.BackColor == Color.YellowGreen)
            {
                MessageBox.Show("The chair " + lblChair.Text + " is chosen.");
            }
        }



        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();

            if (form6.ShowDialog() == DialogResult.OK)
            {
               

                DisplayCustomerList(); // Refreshes the ListBox from the database
                DisplayTotalPrice();

                Customer cus = new Customer();
                cus.FullName = form6.CustomerName;
                cus.Email = form6.CustomerEmail;

                // Alternative way to access the entered values without exposing controls

                TableLayoutPanel[] panels = { pnChair1, pnChair2, pnChair3, pnChair4 };

                List<string> selectedSeats = new List<string>();
                foreach (TableLayoutPanel panel in panels)
                {
                    int panelIndex = (int)panel.Tag;
                    for (int i = 0; i < panel.Controls.Count; i++)
                    {
                        Label lblChair = panel.Controls[i] as Label;
                        if (lblChair != null && lblChair.BackColor == Color.SkyBlue)
                        {
                            lblChair.BackColor = Color.YellowGreen;
                            int chair = int.Parse(lblChair.Text);
                            cus.Chairs.Add((panelIndex, chair));
                        }
                    }
                }
                cus.UpdatePrice();
                ListCustomer.Add(cus);

              
                DatabaseRecord.SaveCustomer(cus, this.SelectedConcertId);
               
              

                DisplayCustomerList();
                DisplayTotalPrice();
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is Booking)
                    {
                        ((Booking)openForm).RefreshCustomerGrid();
                    }
                }

            }
        }

        private void DisplayTotalPrice()
        {
            double sum = 0;
            foreach (Customer cus in ListCustomer)
            {
                sum += cus.Price;
            }
            lblprice.Text = sum.ToString("C");

        }

        private void DisplayCustomerList()
        {
            listBoxCustomer.DataSource = null; // Unbind first
            ListCustomer = DatabaseRecord.LoadAllCustomers();
            listBoxCustomer.DataSource = ListCustomer; // Rebind
            listBoxCustomer.DisplayMember = "FullName";
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (listBoxCustomer.SelectedIndex != -1)
            {
                Customer cus = listBoxCustomer.SelectedItem as Customer;

                TableLayoutPanel[] panels = { pnChair1, pnChair2, pnChair3, pnChair4 };

                foreach (TableLayoutPanel panel in panels)
                {
                    int panelIndex = (int)panel.Tag;

                    for (int i = 0; i < panel.Controls.Count; i++)
                    {
                        Label labelChair = panel.Controls[i] as Label;
                        if (labelChair == null) continue;

                        int codeChair = int.Parse(labelChair.Text);

                        // ✅ Match by BOTH panel index and chair number
                        if (cus.Chairs.Contains((panelIndex, codeChair)))
                        {
                            labelChair.BackColor = Color.LightGray;

                        }
                    }
                }
                ListCustomer.Remove(cus);
                DisplayCustomerList();
                DisplayTotalPrice();
            }
            else
            {
                MessageBox.Show("Please select your name to cancel order.");
            }
        }

        private void listBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCustomer.SelectedItem is Customer cus)
            {
                // Displaying directly on labels
                lblprice.Text = $"{cus.Price:C}";

                string seatSuffix = (cus.Chairs.Count == 1) ? "seat" : "seats";
                lblseats.Text = $" {cus.Chairs.Count} {seatSuffix}";
            
        }
            else
            {
                // Clear labels if nothing is selected
                lblprice.Text = "---";
                lblseats.Text = "---";
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            int panelIndex = 1;
            foreach (var panel in new[] { pnChair1, pnChair2, pnChair3, pnChair4 })
            {
                panel.Tag = panelIndex++;
                DrawChairs(panel);
            }
            ListCustomer = DatabaseRecord.LoadAllCustomers();

            
            DisplayCustomerList();
            DisplayTotalPrice();
        }

        private void btnproceedpayment_Click(object sender, EventArgs e)
        {

            if (listBoxCustomer.SelectedIndex != -1)
            {
                // 1. Get the selected customer object
                Customer selec = ListCustomer[listBoxCustomer.SelectedIndex];

                // 2. Perform the calculation to ensure data is fresh
                selec.UpdatePrice();

                // 3. Initialize the receipt form
                PaymentMethod form4 = new PaymentMethod();

                // --- PUT THE CODE HERE ---
                form4.eventName = this.SelectedEventName;
                form4.TotalPriceToDisplay = lblprice.Text;

                // Passing the data from the 'selec' object to the receipt form
                form4.CustomerName = selec.FullName;    // Ensure PaymentMethod has a public string CustomerName
                form4.CustomerEmail = selec.Email;      // Ensure PaymentMethod has a public string CustomerEmail
                form4.TicketCount = selec.Chairs.Count; // Ensure PaymentMethod has a public int TicketCount
                form4.subTotal = (decimal)selec.Price;
                // -------------------------

                form4.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a customer from the list first!");
            }
        }
        }
}
