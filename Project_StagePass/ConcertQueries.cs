using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_StagePass
{
    public static class ConcertQueries
    {
        public static List<Concert> GetBTSConcerts(List<Concert> all) =>
        all.Where(c => c.ArtistName == "BTS").ToList();

        public static List<Concert> GetConcertsByVenue(List<Concert> all, string venue) =>
            all.Where(c => c.VenueName == venue).ToList();
    }
}
