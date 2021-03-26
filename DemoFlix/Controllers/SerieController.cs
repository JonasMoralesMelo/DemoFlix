using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoFlix.Enum;
using DemoFlix.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoFlix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        // GET: api/<SerieController>
        [HttpGet]
        public List<Serie> Get()
        {
            SerieRepositorio repositorio = new SerieRepositorio();
            return repositorio.Lista();
        }

        // GET api/<SerieController>/5

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SerieController>
        [HttpPost]
        public List<Serie> Post([FromBody] Serie serie)
        {
            SerieRepositorio repositorio = new SerieRepositorio();
            repositorio.Insere(serie);
            return repositorio.Lista();

        }

        // PUT api/<SerieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SerieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
