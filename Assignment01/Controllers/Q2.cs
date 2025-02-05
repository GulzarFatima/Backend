using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{
    [Route("api/q2")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// Returns a greeting message based on entered name.
        /// </summary>
        /// "name" = The name of the person to greet.
        /// <return> A string message "Hi {name}!"</return>
        /// <example1>
        /// GET http://localhost:7290/api/q2/greeting?name=Gary
        /// Response: "Hi Gary!"
        /// </example1>
        /// <example2>
        /// GET http://localhost:7290/api/q2/greeting?name=Ren%C3%A9e
        /// Response: "Hi Renée!"
        /// </example2>

        [HttpGet("greeting")]
        public string Greeting(string name)
        {
            return $"Hi {name}!";
        }
    }
}
