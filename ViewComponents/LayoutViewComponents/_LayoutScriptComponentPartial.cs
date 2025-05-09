using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio_Website.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
