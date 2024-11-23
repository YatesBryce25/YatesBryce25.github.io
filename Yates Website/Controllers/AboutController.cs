using Microsoft.AspNetCore.Mvc;

namespace Yates_Website.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Me()
        {
            return View();
        }
    }
}
