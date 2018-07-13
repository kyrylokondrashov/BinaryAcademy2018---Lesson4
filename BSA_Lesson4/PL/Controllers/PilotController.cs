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
    [Route("/pilot")]
    public class PilotController : Controller
    {
        IService<PilotsDTO> pilotService;

        public PilotController(IService<PilotsDTO> serv)
        {
            pilotService = serv;
        }


        // GET: /pilot
        [HttpGet]
        public string Get()
        {
            var list = pilotService.GetAll();
            string res = JsonConvert.SerializeObject(list);
            return res;
        }

        //GET: /pilot/:id
        [HttpGet("{id}")]
        public string Get(int id)
        {
            try
            {
                var pilot = pilotService.GetById(id);
                string res = JsonConvert.SerializeObject(pilot);
                return res;
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //GET: /pilot/:id/name
        [HttpGet("{id}/name")]
        public string GetName(int id)
        {
            try
            {
                var pilot = (pilotService.GetById(id)).Name;
                return $"This pilot has name {pilot}";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //GET: /pilot/:id/surname
        [HttpGet("{id}/surname")]
        public string GetSurname(int id)
        {
            try
            {
                var pilot = (pilotService.GetById(id)).Surname;
                return $"This pilot has surname {pilot}";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //GET: /pilot/:id/date
        [HttpGet("{id}/surname")]
        public string GetDate(int id)
        {
            try
            {
                var pilot = (pilotService.GetById(id)).DateOfBirth;
                return $"This pilot has date of birtth {pilot}";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //GET: /pilot/:id/experience
        [HttpGet("{id}/experience")]
        public string GetExperience(int id)
        {
            try
            {
                var pilot = (pilotService.GetById(id)).Experience;
                return $"This pilot has experience {pilot}";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        //DELETE pilot/id
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            try
            {
                pilotService.Delete(id);
                return $"Deleted element with {id} id";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //DELETE pilot
        [HttpDelete]
        public string DeleteAll()
        {
            pilotService.DeleteAll();
            return "All data deleted";
        }

        //POST
        // {
        //   "Id": 1,
        //   "Name": 0,
        //   "Surname": 0
        //   "DateOfBirth": "1980-09-13 12:13:14",
        //   "Expirience": 0
        //}
        [HttpPost]
        public string CreateNewElem([FromBody] PilotsDTO element)
        {
            if (!ModelState.IsValid)
                return "Not valid data";
            try
            {
                pilotService.Create(element);
                return "Created the new element";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        // PUT pilot/id
        // {
        //   "Id": 1,
        //   "Name": 0,
        //   "Surname": 0
        //   "DateOfBirth": "1980-09-13 12:13:14",
        //   "Expirience": 0
        //}
        [HttpPut("{id}")]
        public string UpdateElem(int id, [FromBody] PilotsDTO element)
        {
            if (!ModelState.IsValid)
                return "Not valid data";
            try
            {
                pilotService.Update(id, element);
                return "Updated new elemnt";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
