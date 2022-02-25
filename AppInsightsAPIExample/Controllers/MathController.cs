using AppInsightsAPIExample.models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace AppInsightsAPIExample.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {

        private readonly ILogger<MathController> _logger;

        public MathController(ILogger<MathController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Math is fun";
        }

        [EnableCors]
        [HttpPost]
        public Mathy Post([FromBody] Mathy denomintor)
        {
            var mathy = denomintor;

            mathy.Answer = 1000 / mathy.Denominator;
            
            return mathy;

        }

    }
}
