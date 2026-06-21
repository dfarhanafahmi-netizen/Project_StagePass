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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblComingSoon_Click(object sender, EventArgs e)
        {

        }

        private void btnBackUC_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)Application.OpenForms["Form1"];

            if (mainForm != null)
            {
               
                mainForm.Show();

               
                this.Close();
            }
            else
            {
              
                Form1 newMainForm = new Form1();
                newMainForm.Show();
                this.Close();
            }
        }

        private void btnGO1_Click(object sender, EventArgs e)
        {
            DetailsGoBTS form7 = new DetailsGoBTS();
            form7.ShowDialog();
        }

        private void btnGo2_Click(object sender, EventArgs e)
        {
            DetailsGoWeeknd form6 = new DetailsGoWeeknd();
            form6.ShowDialog();
        }

        private void btnGo3_Click(object sender, EventArgs e)
        {
            DetailsGoLaufey form5 = new DetailsGoLaufey();
            form5.ShowDialog();
        }

        private void btnNextUC_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
