using System;
namespace Common.DTO
{
    public class DeparturesDTO
    {
        public int Id { get; set; }
        public int FlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public int CrewId { get; set; }
        public int AircraftId { get; set; }
    }
}
