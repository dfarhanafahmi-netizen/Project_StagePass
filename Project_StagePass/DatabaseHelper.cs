using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_StagePass
{
    public static class DatabaseHelper
    {
        public static string ConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Desktop\YEAR 2 SEM 2 20252026\DITP 2123  EVENT DRIVEN PROGRAMMING\Project_StagePass\Project_StagePass\Project_StagePass\ConcertTicket.mdf"";Integrated Security=True";

        public static DataTable ExecuteQuery(string query)
        {
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
