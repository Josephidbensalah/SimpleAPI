using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Joseph bens";
        }
    }
}
