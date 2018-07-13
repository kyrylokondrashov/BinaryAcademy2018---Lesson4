using System;
using System.Linq;
using DAL.Models;
using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class CrewsRepository: IRepository<Crews>
    {
        ISource dataSource;

        public CrewsRepository(ISource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Create(Crews item)
        {
            dataSource.CrewsList.Add(item);
        }

        public void Delete(int id)
        {
            var crews = dataSource.CrewsList.Where(c => c.Id == id).FirstOrDefault();
            dataSource.CrewsList.Remove(crews);
        }

        public void DeleteAll()
        {
            dataSource.CrewsList.Clear();
        }


        public List<Crews> GetAll()
        {
            return dataSource.CrewsList;
        }

        public Crews GetById(int id)
        {
            return dataSource.CrewsList.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Update(int id, Crews item)
        {
            var crews = dataSource.CrewsList.Where(acr => acr.Id == id).FirstOrDefault();
            dataSource.CrewsList.Remove(crews);
            dataSource.CrewsList.Add(item);
            
        }
    }
}
