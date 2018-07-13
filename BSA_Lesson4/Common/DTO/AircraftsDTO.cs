using System;
namespace Common.DTO
{
    public class AircraftsDTO
    {
		public int Id { get; set; }
		public string AircraftName { get; set; }
		public int CurrentModelId { get; set; }
		public DateTime AircraftBuildDate { get; set; }
        public TimeSpan AircraftExpluatationSpan { get; set; }
    }
}
