using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message.
        /// </summary>

        /// <returns>
        /// A string message: "Welcome to 5125!"
        /// </returns>

        /// <example>
        /// GET https://localhost:xx/api/q1/Welcome
        /// </example>
       
        [HttpGet(template:"/api/q1/Welcome")]
        public string GetWelcomeMessage()
        {
            string message = "Welcome to 5125!";
            return message;
        }
    }
}
