using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api_analisis.Controllers
{
    [ApiController]
    [Route("Values")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<string> Get(int id)
        {
            return new List<string>()
            {
                "Carne", "Verduras", "Frutas", "Lacteos"
            };
        }
        
    }
}
