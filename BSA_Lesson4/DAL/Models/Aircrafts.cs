using System;
namespace DAL.Models
{
    public class Aircrafts
    {
        public int Id { get; set; }
        public string AircraftName { get; set; }
        public int CurrentModelId { get; set; }
        public DateTime AircraftBuildDate { get; set; }
        public TimeSpan AircraftExpluatationSpan { get; set; }
    }
}
