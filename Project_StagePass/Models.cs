using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_StagePass
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
       
        public List<(int panel, int chair)> Chairs { get; set; } = new List<(int, int)>();
        public double Price { get; set; }

        public void UpdatePrice() => Price = Chairs.Count * 90;
}
      

    

    public class BookingRecord
    {
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public string ConcertId { get; set; }
        public DateTime BookingDate { get; set; }
    }

    public class Concert
    {
        public string ConcertId { get; set; }
        public string ArtistName { get; set; }
        public string TourName { get; set; }
        public string VenueName { get; set; }
    }
   

}
