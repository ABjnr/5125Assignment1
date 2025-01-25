using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretIntegerController : ControllerBase
    {
        /// <summary>
        /// Returns an acknowledgement of the {secret} integer
        /// </summary>
        /// <param name="secret">
        ///    The secret integer 
        /// </param>
        /// 
        /// <example> 
        /// POST https://localhost:xx/api/q5/secret 
        /// HEADER : Content-Type: application/x-www-form-urlencoded
        /// Data: secret=3
        /// -> "Shh..  the secret is 3"
        /// </example>
        /// 
        /// <example>
        /// POST https://localhost:xx/api/q5/secret 
        /// HEADER : Content-Type: application/x-www-form-urlencoded
        /// Data: secret=-200
        /// -> "Shh..  the secret is -200"
        /// </example>

        [HttpPost(template:"/api/q5/secret")]
        [Consumes("application/x-www-form-urlencoded")]
        public string PostSecretInteger([FromForm]int secret)
        {

           string message = $"Shh.. the secret is {secret}" ;
           return message;
        }

    }
}
