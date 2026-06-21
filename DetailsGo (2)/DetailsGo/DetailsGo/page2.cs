using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetailsGo
{
    public partial class Form2 : Form
    {
        //Declare customer list
        List<Customer> ListCustomer = new List<Customer>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int panelIndex = 1;
            foreach (var panel in new[] { pnChair1, pnChair2, pnChair3, pnChair4 })
            {
                panel.Tag = panelIndex++;
                DrawChairs(panel);
            }
                
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxCustomer.SelectedIndex != -1) 
            {
                Customer cus = ListCustomer[listBoxCustomer.SelectedIndex];
                labelPrice.Text = cus.Price.ToString("C");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            if (form3.ShowDialog() == DialogResult.OK)
            {
                Customer cus = new Customer();
                cus.NameCustomer = form3.CustomerName;
                cus.PhoneNumber = form3.PhoneNumber;
                // Alternative way to access the entered values without exposing controls

                TableLayoutPanel[] panels = { pnChair1, pnChair2, pnChair3, pnChair4 };

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
                            cus.chairs.Add((panelIndex, chair)); // ✅ store panel + chair
                        }
                    }
                }

                ListCustomer.Add(cus);

                //Call Display TotalMoney
                DisplayTotalPrice();

                //DisplayCustomerListBox function
                DisplayCustomerList();
            }
        }
        private void DisplayTotalPrice()
        {
            double sum = 0;
            foreach (Customer cus in ListCustomer)
            {
                sum += cus.Price;
            }
                labelPrice.Text = sum.ToString("C");
            
        }

        private void DisplayCustomerList()
        {
            listBoxCustomer.Items.Clear();
            foreach (Customer cus in ListCustomer)
            {
                listBoxCustomer.Items.Add(cus);
            }
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
                        if (cus.chairs.Contains((panelIndex, codeChair)))
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
                MessageBox.Show("Please select a customer");    
            }
        }
    }
}

