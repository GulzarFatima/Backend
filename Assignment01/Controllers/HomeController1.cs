using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
