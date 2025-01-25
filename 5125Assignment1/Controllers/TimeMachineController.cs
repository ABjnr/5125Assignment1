using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeMachineController : ControllerBase
    {/// <summary>
     /// Returns a string representation of the current date (formatted yyyy-MM-dd), adjusted by {days}
     /// </summary>
     /// 
     /// <param name="days">
     /// Number of days to convert to date
     /// </param>
     /// 
     /// <example>
     /// GET https://localhost:xx/api/q7/timemachine/1
     /// -> 2000-01-02
     /// </example>
     /// 
     /// <example>
     /// GET https://localhost:xx/api/q7/timemachine/-1
     /// -> 1999-12-31
     /// </example>
        [HttpGet(template: "/api/q7/timemachine/{days}")]
        public string TimeMachine(int days)
        {
            int numberOfDays = days;

            var getDate = new DateTime(2000, 1, 1);
            var daysToDate = getDate.AddDays(numberOfDays);

            return daysToDate.ToString("yyyy-MM-dd");

            /// youtube video reference
            /// Video title: 17: DateTime in C# | Creating Dates and Times in C# | C# Tutorial For Beginners | C Sharp Tutorial
            /// url: https://www.youtube.com/watch?v=KKzSQ6r93dY
            /// 


        }
    }
}
