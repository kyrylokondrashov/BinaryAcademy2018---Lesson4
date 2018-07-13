using System;
using DAL.Models;
using System.Linq;
using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class DeparturesRepository: IRepository<Departures>
    {
        ISource dataSource;
        public DeparturesRepository(ISource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Create(Departures item)
        {
            dataSource.DeparturesList.Add(item);
        }

        public void Delete(int id)
        {
            var departures = dataSource.DeparturesList.Where(d => d.Id == id).FirstOrDefault();
            dataSource.DeparturesList.Remove(departures);

        }

        public void DeleteAll()
        {
            dataSource.DeparturesList.Clear();
        }

        public List<Departures> GetAll()
        {
            return dataSource.DeparturesList;
        }

        public Departures GetById(int id)
        {
            return dataSource.DeparturesList.Where(d => d.Id == id).FirstOrDefault();
        }

        public void Update(int id, Departures item)
        {
            var crews = dataSource.DeparturesList.Where(acr => acr.Id == id).FirstOrDefault();
            dataSource.DeparturesList.Remove(crews);
            dataSource.DeparturesList.Add(item);
        }
    }
}
