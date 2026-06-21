using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void venuesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.venuesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void venuesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.venuesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.dataSet1.Bookings);
            // TODO: This line of code loads data into the 'dataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dataSet1.Users);
            // TODO: This line of code loads data into the 'dataSet1.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.dataSet1.Tickets);
            // TODO: This line of code loads data into the 'dataSet1.TicketPackages' table. You can move, or remove it, as needed.
            this.ticketPackagesTableAdapter.Fill(this.dataSet1.TicketPackages);
            // TODO: This line of code loads data into the 'dataSet1.Concerts' table. You can move, or remove it, as needed.
            this.concertsTableAdapter.Fill(this.dataSet1.Concerts);
            // TODO: This line of code loads data into the 'dataSet1.Concerts' table. You can move, or remove it, as needed.
            this.concertsTableAdapter.Fill(this.dataSet1.Concerts);
            // TODO: This line of code loads data into the 'dataSet1.Venues' table. You can move, or remove it, as needed.
            this.venuesTableAdapter.Fill(this.dataSet1.Venues);

        }
    }
}
