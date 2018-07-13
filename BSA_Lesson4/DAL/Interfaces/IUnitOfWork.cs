using System;
using System.Collections.Generic;
using DAL.Models;
using DAL.Interfaces;
namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Aircrafts> AircraftsRepository {get;}
        IRepository<AircraftsModels> AircraftsModelsRepository {get;}
        IRepository<Crews> CrewsRepository {get;}
        IRepository<Departures> DeparturesRepository {get;}
        IRepository<Flights> FlightsRepository {get;}
        IRepository<Pilots> PilotsRepository {get;}
        IRepository<Stewardesses> StewardessesRepository {get;}
        IRepository<Tickets> TicketsRepository {get;}
        void Save();
    }
}
