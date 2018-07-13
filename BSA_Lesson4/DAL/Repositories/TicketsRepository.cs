using System;
using DAL.Models;
using System.Linq;
using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class TicketsRepository: IRepository<Tickets>
    {
        ISource dataSource;
        public TicketsRepository(ISource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Create(Tickets item)
        {
            dataSource.TicketsList.Add(item);
        }

        public void Delete(int id)
        {
            var ticket = dataSource.TicketsList.Where(t => t.Id == id).FirstOrDefault();
            dataSource.TicketsList.Remove(ticket);
        }

        public void DeleteAll()
        {
            dataSource.TicketsList.Clear();
        }

        public List<Tickets> GetAll()
        {
            return dataSource.TicketsList;
        }

        public Tickets GetById(int id)
        {
            return dataSource.TicketsList.Where(t => t.Id == id).FirstOrDefault();
        }

        public void Update(int id, Tickets item)
        {
            var t = dataSource.TicketsList.Where(tt => tt.Id == id).FirstOrDefault();
            dataSource.TicketsList.Remove(t);
            dataSource.TicketsList.Add(item);
        }
    }
}
