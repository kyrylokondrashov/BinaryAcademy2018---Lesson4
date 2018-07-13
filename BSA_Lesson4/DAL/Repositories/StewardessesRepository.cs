using System;
using DAL.Models;
using System.Linq;
using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class StewardessesRepository: IRepository<Stewardesses>
    {
        ISource dataSource;
        public StewardessesRepository(ISource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Create(Stewardesses item)
        {
            dataSource.StewardessesList.Add(item);
        }

        public void Delete(int id)
        {
            var stdw = dataSource.StewardessesList.Where(s => s.Id == id).FirstOrDefault();
            dataSource.StewardessesList.Remove(stdw);
        }

        public void DeleteAll()
        {
            dataSource.StewardessesList.Clear();
        }

        public List<Stewardesses> GetAll()
        {
            return dataSource.StewardessesList;
        }

        public Stewardesses GetById(int id)
        {
            return dataSource.StewardessesList.Where(s => s.Id == id).FirstOrDefault();
        }

        public void Update(int id, Stewardesses item)
        {
            var stdw = dataSource.StewardessesList.Where(s => s.Id == id).FirstOrDefault();
            dataSource.StewardessesList.Remove(stdw);
            dataSource.StewardessesList.Add(item);
        }
    }
}
