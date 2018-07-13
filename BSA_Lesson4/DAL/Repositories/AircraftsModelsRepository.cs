using System;
using DAL.Models;
using System.Linq;
using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class AircraftsModelsRepository: IRepository<AircraftsModels>
    {
        ISource dataSource;
        public AircraftsModelsRepository(ISource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Create(AircraftsModels item)
        {
            dataSource.AircraftsModelsList.Add(item);
        }

        public void Delete(int id)
        {
            var am = dataSource.AircraftsModelsList.Where(aml => aml.Id == id).FirstOrDefault();
            dataSource.AircraftsModelsList.Remove(am);
        }

        public void DeleteAll()
        {
            dataSource.AircraftsModelsList.Clear();
        }

        public List<AircraftsModels> GetAll()
        {
            return dataSource.AircraftsModelsList;
        }

        public AircraftsModels GetById(int id)
        {
            var am = dataSource.AircraftsModelsList.Where(aml => aml.Id == id).FirstOrDefault();
            return am;
        }


        public void Update(int id, AircraftsModels item)
        {
            var t = dataSource.AircraftsModelsList.Where(aml => aml.Id == id).FirstOrDefault();
            dataSource.AircraftsModelsList.Remove(t);
            dataSource.AircraftsModelsList.Add(item);
        }
    }
}
