using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio_Website.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
