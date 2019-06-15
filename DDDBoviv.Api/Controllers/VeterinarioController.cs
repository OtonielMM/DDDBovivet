

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDBovivet.Domain.Reproducao.Entities;
using DDDBovivet.Domain.Reproducao.Repositories;
using DDDBovivet.Infra.Contexts;
using DDDBovivet.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DDDBoviv.Api.Controllers
{
    [Route("api/[controller]")]
    public class VeterinarioController : Controller
    {
        private readonly IVeterinarioRepository _repository;

        public VeterinarioController(IVeterinarioRepository repository)
        {
            _repository = repository;
        }


        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veterinario>>> Get()
        {
            return await _repository.GetVeterinarios();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Veterinario veterinario)
        {
            try
            {
                _repository.Save(veterinario);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
            }

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}