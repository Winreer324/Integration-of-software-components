using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GuitarsProject;
using GuitarsProject.DAL;

namespace GuitarStoreWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Autos")]
    public class AutosController : Controller
    {
        AutoRepository autos;

        public AutosController(AutoContext context)
        {
            autos = new AutoRepository(context);
        }

        // GET: api/Autos
        [HttpGet]
        public IEnumerable<Auto> GetAutos()
        {
            var g = autos.Get();
            return g;
        }

        // GET: api/Autos/5
        [HttpGet("{id}")]
        public IActionResult GetAuto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var auto = autos.Get(id);

            if (auto == null)
            {
                return NotFound();
            }

            return Ok(auto);
        }

        // PUT: api/Autos/5
        [HttpPut("{id}")]
        public IActionResult PutAuto([FromRoute] int id, [FromBody] Auto auto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != auto.Id)
            {
                return BadRequest();
            }
    
            try
            {
                autos.Update(auto);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Autos
        [HttpPost]
        //[Route("SaveDesignedReport")]
        public IActionResult PostAuto([FromBody] Auto auto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            autos.Create(auto);

            return CreatedAtAction("Autos", new { id = auto.Id}, auto);
        }

        // DELETE: api/Autos/5
        [HttpDelete("{id}")]
        public IActionResult DeleteAuto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool isDeleted = autos.Delete(id);
            if (!isDeleted)
            {
                return NotFound();
            }

            return Ok(true);
        }

        private bool AutoExists(int id)
        {
            return autos.IsExists(id);
        }
    }
}