using Microsoft.AspNetCore.Mvc;

namespace WorkPortal_ASP.Net.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
