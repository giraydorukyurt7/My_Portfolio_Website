using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio_Website.ViewComponents
{
    public class _WorksComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
