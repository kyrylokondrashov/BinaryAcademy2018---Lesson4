using System;
using System.Collections.Generic;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Source
{
    public class Source : ISource
    {


        public Source()
        {
            TicketsList = new List<Tickets>{
                new Tickets{Id =1, Price= 100, FlightId = 1},
                new Tickets{Id =2, Price= 100, FlightId = 1},
                new Tickets{Id =3, Price= 101, FlightId = 2},
                new Tickets{Id =4, Price= 101, FlightId = 2},
                new Tickets{Id =5, Price= 102, FlightId = 3},
                new Tickets{Id =6, Price= 102, FlightId = 3},
                new Tickets{Id =7, Price= 103, FlightId = 4},
                new Tickets{Id =8, Price= 103, FlightId = 4}

            };

            StewardessesList = new List<Stewardesses>
            {
                new Stewardesses{Id =1, Name= "Alica", Surname="Alison", DateOfBirth = new DateTime(1990,09,12,12,13,14)},
                new Stewardesses{Id =2, Name= "Rosa", Surname="Rosason", DateOfBirth = new DateTime(1990,09,13,12,13,14)},
                new Stewardesses{Id =3, Name= "Eva", Surname="Evason", DateOfBirth = new DateTime(1990,09,12,14,13,14)},
                new Stewardesses{Id =4, Name= "Jenn", Surname="Jennson", DateOfBirth = new DateTime(1990,09,15,12,13,14)},
                new Stewardesses{Id =5, Name= "Hermy", Surname="Hermyson", DateOfBirth = new DateTime(1990,09,16,12,13,14)},
                new Stewardesses{Id =6, Name= "Alica", Surname="Evason", DateOfBirth = new DateTime(1990,09,12,17,13,14)}
            };

            PilotsList = new List<Pilots>
            {
                new Pilots{Id = 1, Name="Henry", Surname="Henryson",DateOfBirth = new DateTime(1980,09,12,12,13,14), Experience = 10},
                new Pilots{Id = 2, Name="Andrew", Surname="Andrewson",DateOfBirth = new DateTime(1980,09,13,12,13,14), Experience = 11},
                new Pilots{Id = 3, Name="Jonh", Surname="Jonhson",DateOfBirth = new DateTime(1980,09,12,14,13,14), Experience = 12},
                new Pilots{Id = 4, Name="Harry", Surname="Harryson",DateOfBirth = new DateTime(1980,09,15,12,13,14), Experience = 13}
            };

            CrewsList = new List<Crews>
            {
                new Crews {Id=1,PilotId=1,StewardessList = new List<int>{1,2}},
                new Crews {Id=2,PilotId=2,StewardessList = new List<int>{3}},
                new Crews {Id=3,PilotId=3,StewardessList = new List<int>{4,5}},
                new Crews {Id=4,PilotId=4,StewardessList = new List<int>{6}},
            };

            DeparturesList = new List<Departures>
            {
                new Departures{Id =1, FlightID =1, DepartureDate=new DateTime(2018,10,12,15,18,10), CrewId = 1, AircraftId=1 },
                new Departures{Id =2, FlightID =2, DepartureDate=new DateTime(2018,10,13,15,18,10), CrewId = 1, AircraftId=2 },
                new Departures{Id =3, FlightID =3, DepartureDate=new DateTime(2018,10,14,15,18,10), CrewId = 1, AircraftId=3 },
                new Departures{Id =4, FlightID =4, DepartureDate=new DateTime(2018,10,15,15,18,10), CrewId = 1, AircraftId=4}
            };

            AircraftsList = new List<Aircrafts>
            {
                new Aircrafts{Id=1, AircraftName="Ty101", AircraftBuildDate=new DateTime(2000,10,12,15,18,10), CurrentModelId = 1, AircraftExpluatationSpan= new TimeSpan(50000,0,0)},
                new Aircrafts{Id=2, AircraftName="Ty202", AircraftBuildDate=new DateTime(2001,10,12,15,18,10), CurrentModelId = 2, AircraftExpluatationSpan= new TimeSpan(60000,0,0)},
                new Aircrafts{Id=3, AircraftName="Ty303", AircraftBuildDate=new DateTime(1999,10,12,15,18,10), CurrentModelId = 3, AircraftExpluatationSpan= new TimeSpan(70000,0,0)},
                new Aircrafts{Id=4, AircraftName="Ty404", AircraftBuildDate=new DateTime(1998,10,12,15,18,10), CurrentModelId = 4, AircraftExpluatationSpan= new TimeSpan(80000,0,0)}
            };

            AircraftsModelsList = new List<AircraftsModels>
            {
                new AircraftsModels{Id=1, ModelName="Antonov-111", AircraftTonnage=1000, PlacesCount=500},
                new AircraftsModels{Id=2, ModelName="Ruslanov-222", AircraftTonnage=1200, PlacesCount=600},
                new AircraftsModels{Id=3, ModelName="Karasov-333", AircraftTonnage=1400, PlacesCount=700},
                new AircraftsModels{Id=4, ModelName="Menesov-444", AircraftTonnage=1600, PlacesCount=800}
            };

            FlightsList = new List<Flights> {
            new Flights{Id=1,PointOfDepartures="Kiev/Zhulyany", TimeOfDeparture=new DateTime(2018,10,12,15,18,10),PointOfDestination="London/Hitrow",TimeOfArrival=new DateTime(2018,10,13,15,18,10),Tickets=new List<int>{ 1,2} },
            new Flights{Id=2,PointOfDepartures="Kiev/Zhulyany", TimeOfDeparture=new DateTime(2018,10,13,16,19,10),PointOfDestination="Tokio/Haneda",TimeOfArrival=new DateTime(2018,10,14,15,18,10),Tickets=new List<int>{ 3,4}},
            new Flights{Id=3,PointOfDepartures="Kiev/Zhulyany", TimeOfDeparture=new DateTime(2018,10,14,17,20,10),PointOfDestination="Hong-Kong/HKA",TimeOfArrival=new DateTime(2018,10,15,15,18,10),Tickets=new List<int>{ 5,6}},
            new Flights{Id=4,PointOfDepartures="Kiev/Zhulyany", TimeOfDeparture=new DateTime(2018,10,15,18,21,10),PointOfDestination="New-York/NWA",TimeOfArrival=new DateTime(2018,10,16,15,18,10),Tickets=new List<int>{ 7,8}}
                };



        }

        public List<Aircrafts> AircraftsList { get; set; }
        public List<AircraftsModels> AircraftsModelsList { get; set; }
        public List<Crews> CrewsList { get; set; }
        public List<Departures> DeparturesList { get; set; }
        public List<Flights> FlightsList { get; set; }
        public List<Pilots> PilotsList { get; set; }
        public List<Stewardesses> StewardessesList { get; set; }
        public List<Tickets> TicketsList { get; set; }
    }
}
