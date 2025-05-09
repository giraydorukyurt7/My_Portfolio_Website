using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio_Website.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
