using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{

    [Route("api/q6")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// Returns the area of a regular hexagon with side length double {S}.
        /// </summary>
        /// "side" = "Side lenght of hexagon."
        /// <example1>
        /// GET http://localhost:7290/api/q6/hexagon?side=1
        /// Response: 2.598076211353316
        /// </example1>
        /// <example2>
        /// GET http://localhost:7290/api/q6/hexagon?side=1.5
        /// Response: 5.845671475544961
        /// </example2>
        /// <example3>
        /// GET http://localhost:7290/api/q6/hexagon?side=20
        /// Response: 1039.2304845413264
        /// </example3>

        [HttpGet("hexagon")]
        public IActionResult GetHexagonArea(double side)
        {
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return Ok(area);
        }
    }
}
