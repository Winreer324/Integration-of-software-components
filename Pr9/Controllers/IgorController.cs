using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pr9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IgorController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Enter number in url example /3.3";
        }

        // GET api/values/5
        [HttpGet("{x}")]
        public ActionResult<string> Get(double x)
        {
            double result = (double)(Math.Pow(x + (7 / 6.0), 4 / 3.0)) + Math.Sin(Math.Pow(Math.E, x)) + Math.Asin(((double)Math.Cos(Math.PI * x)));
            return $"Результат функции (при x = {x}):{result}";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{x}")]
        public void Put(int x, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{x}")]
        public void Delete(int x)
        {
        }
    }
}
