﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.Interfaces;
using Common.DTO;
using BL.Services;
using DAL.Interfaces;
using DAL.Source;
using DAL.UnitOfWork;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PL.Controllers
{
    //[Produces("application/json")]
    [Route("/ticket")]
    public class TicketController : Controller
    {
        IService<TicketsDTO> ticketService;

        public TicketController(IService<TicketsDTO> serv)
        {
            ticketService = serv;
        }


        // GET: /ticket
        [HttpGet]
        public string Get()
        {
            var list = ticketService.GetAll();
            string res = JsonConvert.SerializeObject(list);
            return res;
        }

        //GET: /ticket/:id
        [HttpGet("{id}")]
        public string Get(int id)
        {
            try
            {
                var ticket = ticketService.GetById(id);
                string res = JsonConvert.SerializeObject(ticket);
                return res;
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //GET: /ticket/:id/price
        [HttpGet("{id}/price")]
        public string GetPrice(int id)
        {
            try
            {
                var ticket = (ticketService.GetById(id)).Price;
                return $"This ticket has price {ticket}";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //GET: /ticket/:id/flightId
        [HttpGet("{id}/flightId")]
        public string GetFlight(int id)
        {
            try
            {
                var ticket = (ticketService.GetById(id)).FlightId;
                return $"This ticket has Aircraft Id {ticket}";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //DELETE ticket/id
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            try
            {
                ticketService.Delete(id);
                return $"Deleted element with {id} id";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        //DELETE ticket
        [HttpDelete]
        public string DeleteAll()
        {
            ticketService.DeleteAll();
            return "All data deleted";
        }

        //POST
        // {
        //   "Id": 1,
        //   "Price": 0,
        //   "FlightId": 0
        //}
        [HttpPost]
        public string CreateNewElem([FromBody] TicketsDTO element)
        {
            if (!ModelState.IsValid)
                return "Not valid data";
            try
            {
                ticketService.Create(element);
                return "Created the new element";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        // PUT ticket/id
        // {
        //   "Id": 1,
        //   "Price": 0,
        //   "FlightId": 0
        //}
        [HttpPut("{id}")]
        public string UpdateElem(int id, [FromBody] TicketsDTO element)
        {
            if (!ModelState.IsValid)
                return "Not valid data";
            try
            {
                ticketService.Update(id,element);
                return "Updated new elemnt";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
