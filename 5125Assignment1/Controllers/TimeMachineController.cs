using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeMachineController : ControllerBase
    {
        [HttpGet(template: "/api/q7/timemachine")]
        [Consumes("application/x-www-form-urlencoded")]

        public string TimeMachine([FromForm]int days)
        {
            return "yel";
        }
    }
}
