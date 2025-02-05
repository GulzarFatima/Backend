using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1 : ControllerBase
    {
        // GET: localhost:xx/api/Assignment01/Get1 -> "Welcome to 5125!"
        [HttpGet(template:"/api/Assignment01/Get1")]
        public string Get1()
        {
            return ("Welcome to 5125!");
        }
    }
}

