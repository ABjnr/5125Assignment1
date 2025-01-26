using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SquashFellowsController : ControllerBase
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="small">
     /// Number of small quantities
     /// </param>
     /// 
     /// <param name="large">
     /// Number of large quantities
     /// </param>
     /// 
     /// <example>
     /// POST https://localhost:xx/api/q8/squashfellows
     /// HEADER Content-Type: application/x-www-form-urlencoded
     /// Data: small=1&large=1
     /// -> 1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58
     /// </example>
     /// 
     /// <example>
     /// POST https://localhost:xx/api/q8/squashfellows
     /// HEADER Content-Type: application/x-www-form-urlencoded
     /// Data: small=2&large=1
     /// -> 2 Small @ $25.50 = $51.00; 1 Large @ $40.50 = $40.50; Subtotal = $91.50; Tax = $11.90 HST; Total = $103.40
     /// </example>
     /// 
     /// <example>
     /// POST https://localhost:xx/api/q8/squashfellows
     /// HEADER Content-Type: application/x-www-form-urlencoded
     /// Data: small=100&large=100
     /// -> 100 Small @ $25.50 = $2550.00; 100 Large @ $40.50 = $4050.00; Subtotal = $6600.00; Tax = $858.00 HST; Total = $7458.00
     /// </example>
        [HttpPost(template: "/api/q8/squashfellows")]
        [Consumes("application/x-www-form-urlencoded")]

        public string GetSquashFellows([FromForm] double small, [FromForm]double large)
        {
            double smallQuantity = small;
            double largeQuantity = large;

            double smallPrice = 25.50;
            double largePrice = 40.50;

            double smallTotal = smallQuantity * smallPrice;
            double largeTotal = largeQuantity * largePrice;

            double subtotal = smallTotal + largeTotal;
            double taxHST = subtotal * 0.13;

            double totalPrice = subtotal + taxHST;
            double totalPriceRounded = Math.Ceiling(totalPrice * 100) / 100;

            return $"{smallQuantity} Small @ ${smallPrice:F2} = ${smallTotal:F2}; {largeQuantity} Large @ ${largePrice:F2} = ${largeTotal:F2}; Subtotal = ${subtotal:F2}; Tax = ${taxHST:F2} HST; Total = ${totalPriceRounded:F2}";
        }
    }
}
