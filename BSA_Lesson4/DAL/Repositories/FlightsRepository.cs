using System;
using DAL.Models;
using System.Linq;
using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class FlightsRepository: IRepository<Flights>
    {
        ISource dataSource;
        public FlightsRepository(ISource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Create(Flights item)
        {
            dataSource.FlightsList.Add(item);
        }

        public void Delete(int id)
        {
            var item = dataSource.FlightsList.Where(f => f.Id == id).FirstOrDefault();
            dataSource.FlightsList.Remove(item);
        }

        public void DeleteAll()
        {
            dataSource.FlightsList.Clear();
        }

        public List<Flights> GetAll()
        {
            return dataSource.FlightsList;
        }

        public Flights GetById(int id)
        {
            var item = dataSource.FlightsList.Where(f => f.Id == id).FirstOrDefault();
            return item;
        }

        public void Update(int id, Flights item)
        {
            var temp = dataSource.FlightsList.Where(f => f.Id == id).FirstOrDefault();
            dataSource.FlightsList.Remove(temp);
            dataSource.FlightsList.Add(item);
        }
    }
}
