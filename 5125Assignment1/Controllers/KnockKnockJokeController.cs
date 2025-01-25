using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnockKnockJokeController : ControllerBase
    {
        /// <summary>
        /// Returns the start of a knock-knock joke: "Who's there?"
        /// </summary>
        /// <returns>
        /// A string: "Who's there?"
        /// </returns>
        /// <example>
        /// POST https://localhost:xx/api/q4/knockknock -> "Who's there?"
        /// </example>


        [HttpPost("/api/q4/knockknock")]

        public string PostKnockKnockJoke()
        {
            string response = "Who's there?";
            return response;
        }

    }
}
