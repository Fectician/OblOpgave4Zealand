using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OBL_4_REST_Football.Managers;
using OBL_4_REST_Football.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OBL_Opgave_4_Rest.Controllers
{
    //Kode af Nicolas Lauridsen, Datamatiker 3b Zealand Erhvervsakademi.
    [Route("FootballPlayer")]
    [ApiController]
    public class FootballController : ControllerBase
    {
        private readonly FootballManager _manager = new FootballManager();
        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public FootballPlayer Post([FromBody] FootballPlayer value)
        {
            return _manager.Add(value);
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public FootballPlayer Put(int id, [FromBody] FootballPlayer value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
