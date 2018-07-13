using System;
namespace DAL.Models
{
    public class Pilots
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Experience { get; set; }
    }
}
