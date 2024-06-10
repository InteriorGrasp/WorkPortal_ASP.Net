using Microsoft.AspNetCore.Mvc;

namespace WorkPortal_ASP.Net.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
