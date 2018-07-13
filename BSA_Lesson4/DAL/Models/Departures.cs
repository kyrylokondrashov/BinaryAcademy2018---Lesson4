using System;
namespace DAL.Models
{
    public class Departures
    {
        public int Id { get; set; }
        public int FlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public int CrewId { get; set; }
        public int AircraftId { get; set; }
    }
}
