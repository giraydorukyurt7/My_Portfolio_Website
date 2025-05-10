using Microsoft.AspNetCore.Mvc;
using My_Portfolio_Website.DAL.Context;

namespace My_Portfolio_Website.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
