using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_StagePass
{
    public static class SecurityHelper
    {
        // Add your valid admin credentials here
        private static Dictionary<string, string> AdminAccounts = new Dictionary<string, string>
        {
            { "admin", "admin123" }
        };

        public static bool Authenticate(string username, string password)
        {
            return AdminAccounts.ContainsKey(username) && AdminAccounts[username] == password;
        }
    }
}
