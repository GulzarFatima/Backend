using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{

    [Route("api/q8")]
    [ApiController]
    public class Q8Controller : ControllerBase
    {
        /// <summary>
        /// ==Case 01
        /// Item01: 1x Small P $25.50 = $25.50
        /// Item02: 1x Large P $40.50 = $40.50
        /// Subtotal: $66.00
        /// Tax: $8.58 hst
        /// Total = $74.58
        /// ==Case 02
        /// Item01: 2x Small P $25.50 = $51.00
        /// Item02: 1x Large P $40.50 = $40.50
        /// Subtotal: $91.50
        /// Tax: $11.90 hst
        /// Total = $103.40
        /// ==Case 03
        /// Item01: 100x Small P $25.50 = $2550.00
        /// Item02: 100x Large P $40.50 = $4050.00
        /// Subtotal: $6600.00
        /// Tax: $858.00 hst
        /// Total = $7458.00
        /// </summary>
        /// Returns checkout summary for an order.
        
        const decimal smallPrice = 25.50m;
        const decimal largePrice = 40.50m;
        const decimal taxRate = 0.13m;

        [HttpPost("squashfellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public IActionResult CalculateCheckout([FromForm] int small, [FromForm] int large)
        {

        // Calculate prices
        decimal smallTotal = small * smallPrice;
            decimal largeTotal = large * largePrice;

            // Subtotal
            decimal subtotal = smallTotal + largeTotal;

            // Tax (13% HST) 
            decimal tax = (subtotal * taxRate);

            // Total (including tax) 
            decimal total = (subtotal + tax);


            string responseMessage = 
                $"{small} small @ {smallPrice:C2} = {smallTotal:C2};" +
                $" {large} Large @ {largePrice:C2} = {largeTotal:C2}; " +
                $"Subtotal = {subtotal:C2}; Tax = {tax:C2} HST; Total = {total:C2}";

            return Ok(responseMessage);
        }
    }
}
