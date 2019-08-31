using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fuse.Context;
using Fuse.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Fuse.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly FuseContext _context;

        public CustomerController(FuseContext context)
        {
            _context = context;

        }
        // GET api/values
        [HttpGet("GetCostumers")]
        public IActionResult GetCustomers()
        {
            var x = _context.Costumer.ToList();
            
            return Ok(_context.Costumer.ToList());
        }

        // GET api/values/5
        [HttpPost("AddCostumer")]
        public IActionResult AddCostumer(Costumer costumer)
        {
            _context.Costumer.Add(costumer);
            _context.SaveChanges();
            return Ok(costumer);

        }

        // POST api/values
        [HttpPost("DeleteCostumer")]
        public IActionResult Post(int Id)
        {
            var del = _context.Costumer.Where(w => w.IdCostumer == Id).SingleOrDefault();
            _context.Costumer.Remove(del);
            var a = _context.SaveChanges();
            if (a == 1)
            {
                return Ok("Deleted");
            }
            else return Ok("Not Deleted");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
