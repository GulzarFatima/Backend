using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{

    [Route("api/q5")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        /// Returns a secret message with the entered number.
        /// </summary>
        /// "number" = "The number to include in the secret message."
        /// <example>
        /// POST http://localhost:xx/api/q5/secret
        /// Response: shh.. the secret is 5
        /// POST http://localhost:7290/api/q4/knockknock
        /// Response: Who's there?
        /// </example>

        [HttpPost("secret")]
        public IActionResult SecretNumber([FromBody] int number)
        {
            return Ok($"SHH.. the secret is {number}");
        }
    }
}
