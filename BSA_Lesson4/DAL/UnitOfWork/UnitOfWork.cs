﻿using System;
using DAL.Interfaces;
using System.Collections.Generic;
using DAL.Repositories;
using DAL.Models;

namespace DAL.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private ISource  dataSource;
        private IRepository<Aircrafts> aircraftsRepository;
        private IRepository<AircraftsModels> aircraftsModelsRepository;
        private IRepository<Crews> crewsRepository;
        private IRepository<Departures> departuresRepository;
        private IRepository<Flights> flightsRepository;
        private IRepository<Pilots> pilotsRepository;
        private IRepository<Stewardesses> stewardessesRepository;
        private IRepository<Tickets> ticketsRepository;




        public IRepository<Aircrafts> AircraftsRepository
        {get
            {
                if (aircraftsRepository == null)
                {
                    aircraftsRepository = new AircraftsRepository(dataSource);
                }
                return aircraftsRepository;
            }
        }

        public IRepository<AircraftsModels> AircraftsModelsRepository 
        {
            get
            {
                if (aircraftsModelsRepository == null)
                {
                    aircraftsModelsRepository = new AircraftsModelsRepository(dataSource);
                }
                return aircraftsModelsRepository;
            }
        }

        public IRepository<Crews> CrewsRepository
        {
            get
            {
                if (crewsRepository == null)
                {
                    crewsRepository = new CrewsRepository(dataSource);
                }
                return crewsRepository;
            }
        }

        public IRepository<Departures> DeparturesRepository 
        {
            get
            {
                if (departuresRepository == null)
                {
                    departuresRepository = new DeparturesRepository(dataSource);
                }
                return departuresRepository;
            }
        }

        public IRepository<Flights> FlightsRepository 
        {
            get
            {
                if (flightsRepository == null)
                {
                    flightsRepository = new FlightsRepository(dataSource);
                }
                return flightsRepository;
            }
        }

        public IRepository<Pilots> PilotsRepository 
        {
            get
            {
                if (pilotsRepository == null)
                {
                    pilotsRepository = new PilotsRepository(dataSource);
                }
                return pilotsRepository;
            }
        }

        public IRepository<Stewardesses> StewardessesRepository 
        {
            get
            {
                if (stewardessesRepository == null)
                {
                    stewardessesRepository = new StewardessesRepository(dataSource);
                }
                return stewardessesRepository;
            }
        }

        public IRepository<Tickets> TicketsRepository
        {
            get
            {
                if (ticketsRepository == null)
                {
                    ticketsRepository = new TicketsRepository(dataSource);
                }
                return ticketsRepository;
            }
        }

        public UnitOfWork(ISource dataSource)
        {
            this.dataSource = dataSource;
        }



        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
