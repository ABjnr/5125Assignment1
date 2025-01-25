using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGreetingController : ControllerBase
    {
        /// <summary>
        /// Returns a greeting to {name}
        /// </summary>
        /// 
        /// <param name="name">
        /// The name of the person to greet
        /// </param>
        /// 
        /// <returns>
        /// A string message: "Hi, {name}"
        /// </returns>
        /// 
        /// <example>
        /// GET https://localhost:xx/api/q2/greeting/Gary
        /// </example>



        [HttpGet(template:"/api/q2/greeting/{name}")]
        public string GreetUsername(String name)
        {
            string message = "Hi, " + name + "!";
            return message;
        }
    }
}
