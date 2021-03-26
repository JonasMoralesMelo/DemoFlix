using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoFlix.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoFlix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        FilmeRepositorio repositorio = new FilmeRepositorio();
        // GET: api/<FilmeController>
        [HttpGet]
        public IList<Filme> Get()
        {
            return repositorio.Lista();
        }

        // GET api/<FilmeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FilmeController>
        [HttpPost]
        public List<Filme> Post([FromBody] Filme filme)
        {
            repositorio.Insere(filme);
            return repositorio.Lista();
        }

        // PUT api/<FilmeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FilmeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
