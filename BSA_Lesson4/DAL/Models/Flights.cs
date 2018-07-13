using System;
using System.Collections.Generic;
namespace DAL.Models
{
    public class Flights
    {
        public int Id { get; set; }
        public string PointOfDepartures { get; set; }
        public DateTime TimeOfDeparture { get; set; }
        public string PointOfDestination { get; set; }
        public DateTime TimeOfArrival { get; set; }
        public List<int> Tickets { get; set; }
    }
}
