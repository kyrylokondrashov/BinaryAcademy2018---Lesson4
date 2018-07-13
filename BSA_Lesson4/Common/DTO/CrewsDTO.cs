using System;
using System.Collections.Generic;
namespace Common.DTO
{
    public class CrewsDTO
    {
		public int Id { get; set; }
		public int PilotId { get; set; }
        public List<int> StewardessList { get; set; }
    }
}
