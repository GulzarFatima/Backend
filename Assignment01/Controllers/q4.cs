using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{

    [Route("api/q4")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// Returns a response to knock knock joke.
        /// </summary>
        /// <example>
        /// POST http://localhost:7290/api/q4/knockknock
        /// Response: Who's there?
        /// </example>
      
        [HttpPost("knockknock")]
        public IActionResult knockknock()
        {
            return Ok("Who's there?");
        }
    }
}
