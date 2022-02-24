using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppInsightsAPIExample.Controllers
{
    [Route("")]
    [Route("api/[controller]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        [HttpGet]
        public string get()
        {

            return "hello";
        }
    }
}
