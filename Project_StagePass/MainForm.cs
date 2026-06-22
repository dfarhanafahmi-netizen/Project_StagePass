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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      

        private void ShowChildForm(Form childForm)
        {
            // 1. Wipe away any database form that was previously displayed in that area
            panelContent.Controls.Clear();

            // 2. Change TopLevel state so it converts into a container control element
            childForm.TopLevel = false;

            // 3. Remove window title borders and dock it to stretch automatically across the screen
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // 4. Bind the child layout directly into the panel control list and make it visible
            panelContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new Booking());
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new BookingTicketTable());
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ConcertTable());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
