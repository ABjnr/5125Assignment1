using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HexagonCalculatorController : ControllerBase
    {
        /// <summary>
        /// Returns the area of a regular hexagon with side length double {S}
        /// </summary>
        /// 
        /// <param name="side">
        /// The integer side 
        /// </param>
        /// 
        /// <example>
        /// GET https://localhost:xx/api/q6/hexagon/1
        /// -> 2.598076211353316
        /// </example>
        /// 
        /// <example>
        /// GET https://localhost:xx/api/q6/hexagon/1.5
        /// -> 5.845671475544961
        /// </example>
        /// 
        /// <example>
        /// GET https://localhost:xx/api/q6/hexagon/20
        /// -> 1039.2304845413264
        /// </example>
        
        [HttpGet(template: "/api/q6/hexagon/{side}")]
        public double GetHexagonArea(double side)
        {

            double S = side;

            // got the calculation formula with assistance from ChatGPT
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(S, 2);

            return area;

            
        }

    }
}
