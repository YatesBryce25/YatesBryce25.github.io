using Microsoft.AspNetCore.Mvc;

namespace Yates_Website.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
