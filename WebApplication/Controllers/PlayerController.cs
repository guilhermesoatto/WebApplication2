using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Service;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace WebApplication.Controllers
{
    [Route("api/player")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private Service.PlayerService service = new PlayerService();
        // GET: api/Jogador
        [HttpGet]
        public IEnumerable<string> Get()
        {
            service.Jogar("2");
            return new string[] { "value1", "value2" };
        }

        // GET: api/Jogador/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "";
        }

        // POST: api/Jogador
        [HttpPost]
        public void Post()
        {
           
        }

        // PUT: api/Jogador/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
