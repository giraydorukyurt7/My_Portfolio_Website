using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio_Website.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
