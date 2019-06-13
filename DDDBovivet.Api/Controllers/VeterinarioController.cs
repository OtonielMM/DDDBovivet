using DDDBovivet.Domain.Reproducao.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DDDBovivet.Api.Controllers
{

    [Route("api/[controller]")]
    public class VeterinarioController : Controllers
    {
        private readonly IVeterinarioRepository _repository;

        public VeterinarioController(IVeterinarioRepository repository)
        {
            _repository = repository;
        }


        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> Get()
        {
            return await _repository.GetCustomers();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            try
            {
                _repository.Save(customer);
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
