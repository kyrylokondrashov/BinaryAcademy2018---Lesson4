using System;
using DAL.Models;
using System.Linq;
using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class AircraftsRepository: IRepository<Aircrafts>
    {
        ISource dataSource;
        public AircraftsRepository(ISource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Create(Aircrafts item)
        {
            dataSource.AircraftsList.Add(item);
        }

        public void Delete(int id)
        {
            var aircraft = dataSource.AircraftsList.Where(a => a.Id == id).FirstOrDefault();
            dataSource.AircraftsList.Remove(aircraft);
        }

        public void DeleteAll()
        {
            dataSource.AircraftsList.Clear();
        }

        public List<Aircrafts> GetAll()
        {
            return dataSource.AircraftsList;
        }

        public Aircrafts GetById(int id)
        {
            return dataSource.AircraftsList.Where(a => a.Id == id).FirstOrDefault();
        }

        public void Update(int id, Aircrafts item)
        {
            var aircraft = dataSource.AircraftsList.Where(acr => acr.Id == id).FirstOrDefault();
            dataSource.AircraftsList.Remove(aircraft);
            dataSource.AircraftsList.Add(item);

        }
    }
}
