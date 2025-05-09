using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio_Website.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
