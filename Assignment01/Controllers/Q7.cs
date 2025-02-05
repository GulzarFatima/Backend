using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{

    [Route("api/q7")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// Returns next and previous date from current date.
        /// </summary>
        /// "days" = "Number of days to adjust the current date."
        /// <example1>
        /// (POSITIVE) GET http://localhost:xx/api/q7/timemachine?days=1
        /// Response: 2000-01-02
        /// </example>
        /// <example2>
        /// (Negative) GET http://localhost:xx/api/q7/timemachine?days=-1
        /// Response: 1999-12-31
        /// </example2>

        [HttpGet("Timemachine")]
        public IActionResult GetTimeMachine(int days)
        {
            DateTime currentDate = new DateTime(2000, 1, 1);
            DateTime adjustedDate = currentDate.AddDays(days);
            return Ok(adjustedDate.ToString("yyy-mm-dd"));
        }
    }
}
