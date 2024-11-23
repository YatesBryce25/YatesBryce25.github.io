using Microsoft.AspNetCore.Mvc;

namespace Yates_Website.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
