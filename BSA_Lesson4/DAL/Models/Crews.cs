using System;
using System.Collections.Generic;
namespace DAL.Models
{
    public class Crews
    {
        public int Id { get; set; }
        public int PilotId { get; set; }
        public List<int> StewardessList { get; set; }
    }
}
