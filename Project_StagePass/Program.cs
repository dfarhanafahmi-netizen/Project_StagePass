using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_StagePass
{
     static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
            DatabaseRecord.InitializeDatabase();
            Application.Run(new MainPage()); 
        }
    }
}
