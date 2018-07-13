using System;
using DAL.Models;
using System.Linq;
using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class PilotsRepository: IRepository<Pilots>
    {
        ISource dataSource;
        public PilotsRepository(ISource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Create(Pilots item)
        {
            dataSource.PilotsList.Add(item);
        }

        public void Delete(int id)
        {
            var item = dataSource.PilotsList.Where(p => p.Id == id).FirstOrDefault();
            dataSource.PilotsList.Remove(item);
        }

        public void DeleteAll()
        {
            dataSource.PilotsList.Clear();
        }

        public List<Pilots> GetAll()
        {
            return dataSource.PilotsList;
        }

        public Pilots GetById(int id)
        {
            return dataSource.PilotsList.Where(p => p.Id == id).FirstOrDefault();
        }

        public void Update(int id, Pilots item)
        {
            var temp = dataSource.PilotsList.Where(p => p.Id == id).FirstOrDefault();
            dataSource.PilotsList.Remove(temp);
            dataSource.PilotsList.Add(item);
        }
    }
}
