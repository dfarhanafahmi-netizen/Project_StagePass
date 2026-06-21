using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsGo
{
    public class Customer
    {
        public Customer()
        {
            chairs = new List<(int panel, int chair)>();
        }
        public string NameCustomer { get; set; }
        public string PhoneNumber { get; set; }

        public List<(int panel, int chair)> chairs { get; set; }

        public double Price
        {
            get
            {
                return chairs.Count * 90;
            }
        }
        public override string ToString()
        {
            return this.NameCustomer;
        }
    }
}
