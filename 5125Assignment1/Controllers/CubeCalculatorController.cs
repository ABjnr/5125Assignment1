using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CubeCalculatorController : ControllerBase
    {
        /// <summary>
        /// Returns the cube of the integer {number}
        /// </summary>
        /// 
        /// <param name="number">
        /// The number to be cubed number * number * number)
        /// </param>
        /// 
        /// <example>
        /// GET https://localhost:xx/api/q3/cube/10
        /// </example>
        /// 
        /// <returns>
        /// An integer: 1000
        /// </returns>
        /// 



        [HttpGet(template:"/api/q3/cube/{number}")]

        public int GetCubeInteger(int number)
        {
            int cube = number * number * number;
            return cube;

        }

    }
}
