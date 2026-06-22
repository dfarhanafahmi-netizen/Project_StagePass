using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_StagePass
{
    public class AnalyticsRecord 
    {
        private List<Customer> _customerList;

        public static decimal CalculateTotalRevenue(List<Customer> customers)
             => (decimal)customers.Sum(c => c.Price);

        public static int CountTotalTickets(List<Customer> customers)
        {
            return customers.Sum(c => c.Chairs != null ? c.Chairs.Count : 0);
        }
     
        public static List<Customer> SearchByName(List<Customer> customers, string name)
        {
            return customers.Where(c => c.FullName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
        }
            

        public static List<string> GetUniqueEmails(List<Customer> customers)
        {
            return customers.Select(c => c.Email)
                            .Distinct()
                            .OrderBy(email => email)
                            .ToList();
        }

        public static Customer GetMostPopularCustomer(List<Customer> customers)
            => customers.OrderByDescending(c => c.Chairs.Count).FirstOrDefault();

        public static List<Customer> GetEmptyOrders(List<Customer> customers)
            => customers.Where(c => c.Chairs.Count == 0).ToList();




       
       
    }
}
