using BMChallenge.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        // GET api/<Fibonacci>/5
        [HttpGet]
        public IEnumerable<int> Get(int el)
        {
            Fibonacci fibonacci = new Fibonacci();

            return fibonacci.returnSerie(el);
        }
    }
}
