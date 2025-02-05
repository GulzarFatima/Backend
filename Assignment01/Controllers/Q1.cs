using Microsoft.AspNetCore.Mvc;

namespace q1.Controllers
{
    [Route("api/q1")]
    [ApiController]
    public class Q1Controller : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message.
        /// </summary>
        /// <returns>A string message "Welcome to 5121!"</returns>
        /// <example>
        /// GET http://localhost:7290/api/q1/welcome
        /// Response: "Welcome to 5125!"
        /// </example>

        [HttpGet("welcome")]
        public string Welcome()
        {
            return ("Welcome to 5125!");
        }
    }
}

