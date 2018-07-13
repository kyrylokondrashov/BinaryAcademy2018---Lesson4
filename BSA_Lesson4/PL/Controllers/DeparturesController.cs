using System;
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
    [Route("/departures")]
    public class DeparturesController : Controller
    {
        IService<DeparturesDTO> departureService;

        public DeparturesController(IService<DeparturesDTO> serv)
        {
            departureService = serv;
        }


        // GET: /departures
        [HttpGet]
        public string Get()
        {
            var list = departureService.GetAll();
            string res = JsonConvert.SerializeObject(list);
            return res;
        }

        //GET: /departures/:id
        [HttpGet("{id}")]
        public string Get(int id)
        {
            try
            {
                var crew = departureService.GetById(id);
                string res = JsonConvert.SerializeObject(crew);
                return res;
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        //GET: /departures/:id/flight
        [HttpGet("{id}")]
        public string GetFlight(int id)
        {
            try
            {
                var crew = (departureService.GetById(id)).FlightID;
                return $"Departure by flight with id {crew}. More information at /flight/:id";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //GET: /departures/:id/dateOfDeparture
        [HttpGet("{id}/dateOfDeparture")]
        public string GetDoD(int id)
        {
            try
            {
                var crew = (departureService.GetById(id)).DepartureDate;
                return $"Departure at {crew}.";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //GET: /departures/:id/crew
        [HttpGet("{id}/crew")]
        public string GetCrewId(int id)
        {
            try
            {
                var crew = (departureService.GetById(id)).CrewId;
                return $"Departure has {crew}. More information at crew/id";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //GET: /departures/:id/aircraft
        [HttpGet("{id}/")]
        public string GetAircraftId(int id)
        {
            try
            {
                var crew = (departureService.GetById(id)).AircraftId;
                return $"Departure by aircraft {crew}. More information at aircraft/id";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //DELETE departures/id
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            try
            {
                departureService.Delete(id);
                return $"Deleted element with {id} id";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //DELETE departures
        [HttpDelete]
        public string DeleteAll()
        {
            departureService.DeleteAll();
            return "All data deleted";
        }

        //POST
        // {
        //   "Id": 1,
        //   "FlightID":2,
        //   "DepartureDate": "1980-09-13 12:13:14",
        //   "CrewId": 1,
        //   "AircraftId": 1
        //}
        [HttpPost]
        public string CreateNewElem([FromBody] DeparturesDTO element)
        {
            if (!ModelState.IsValid)
                return "Not valid data";
            try
            {
                departureService.Create(element);
                return "Created the new element";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        // PUT departures/id
        // {
        //   "Id": 1,
        //   "FlightID":2,
        //   "DepartureDate": "1980-09-13 12:13:14",
        //   "CrewId": 1,
        //   "AircraftId": 1
        //}
        [HttpPut("{id}")]
        public string UpdateElem(int id, [FromBody] DeparturesDTO element)
        {
            if (!ModelState.IsValid)
                return "Not valid data";
            try
            {
                departureService.Update(id, element);
                return "Updated new elemnt";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
