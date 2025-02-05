using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{

    [Route("api/q3")]
    [ApiController]
    public class Q3Controller : ControllerBase
    {
        /// <summary>
        /// Returns the cube of the entered number. 
        /// </summary>
        /// "number" = The number to cube.
        /// <returns> The cubed value of the entered number.</returns>
        /// <example1>
        /// GET http://localhost:7290/api/q3/cube/4
        /// Response: 64
        /// </example1>
        /// <example2>
        /// GET http://localhost:7290/api/q3/cube/-4
        /// Response: -64
        /// </example2>
        /// <example3>
        /// GET http://localhost:7290/api/q3/cube/10
        /// Response: 1000
        /// </example3>
        /// 

        [HttpGet("cube/{number}")]
        public int Cube(int number)
        {
            return number * number * number;
        }
    }
}
