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
    [Route("/aircrafts")]
    public class aircratController : Controller
    {
        IService<AircraftsDTO> crewService;

        public aircratController(IService<AircraftsDTO> serv)
        {
            crewService = serv;
        }


        // GET: /aircrafts
        [HttpGet]
        public string Get()
        {
            var list = crewService.GetAll();
            string res = JsonConvert.SerializeObject(list);
            return res;
        }

        //GET: /aircrafts/:id
        [HttpGet("{id}")]
        public string Get(int id)
        {
            try
            {
                var crew = crewService.GetById(id);
                string res = JsonConvert.SerializeObject(crew);
                return res;
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //GET: /aircrafts/:id/name
        [HttpGet("{id}/weight")]
        public string GetName(int id)
        {
            try
            {
                var crew = (crewService.GetById(id)).AircraftName;
                return $"Aircraft name is {crew}.";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //GET: /aircrafts/:id/type
        [HttpGet("{id}/type")]
        public string GetType(int id)
        {
            try
            {
                var crew = (crewService.GetById(id)).CurrentModelId;
                return $"Aircraft model has number {crew}. More details at aircraftsModel/:id";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //GET: /aircrafts/:id/date
        [HttpGet("{id}/date")]
        public string GetDate(int id)
        {
            try
            {
                var crew = (crewService.GetById(id)).AircraftBuildDate;
                return $"Aircraft was built at {crew}.";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //GET: /aircraftsModel/:id/life
        [HttpGet("{id}/life")]
        public string GetWeight(int id)
        {
            try
            {
                var crew = (crewService.GetById(id)).AircraftExpluatationSpan;
                return $"Aircraft has expluatation span {crew}.";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //DELETE aircrafts/id
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            try
            {
                crewService.Delete(id);
                return $"Deleted element with {id} id";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //DELETE aircrafts
        [HttpDelete]
        public string DeleteAll()
        {
            crewService.DeleteAll();
            return "All data deleted";
        }

        //POST
        // {
        //   "Id": 1,
        //   "AircraftName": "Tytyty,
        //   "CurrentModelId": 1,
        //   "AircraftBuildDate": "1980-09-13 12:13:14",
        //   "AircraftExpluatationSpan": "7000.08:00:00"
        //}
        [HttpPost]
        public string CreateNewElem([FromBody] AircraftsDTO element)
        {
            if (!ModelState.IsValid)
                return "Not valid data";
            try
            {
                crewService.Create(element);
                return "Created the new element";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        // PUT aircrafts/id
        // {
        //   "Id": 1,
        //   "AircraftName": "Tytyty,
        //   "CurrentModelId": 1,
        //   "AircraftBuildDate": "1980-09-13 12:13:14",
        //   "AircraftExpluatationSpan": "7000.08:00:00"
        //}
        [HttpPut("{id}")]
        public string UpdateElem(int id, [FromBody] AircraftsDTO element)
        {
            if (!ModelState.IsValid)
                return "Not valid data";
            try
            {
                crewService.Update(id, element);
                return "Updated new elemnt";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }

}
