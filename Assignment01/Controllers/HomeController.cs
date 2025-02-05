using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
