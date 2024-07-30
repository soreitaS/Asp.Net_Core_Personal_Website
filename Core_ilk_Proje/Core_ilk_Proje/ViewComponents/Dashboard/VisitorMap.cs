using Microsoft.AspNetCore.Mvc;

namespace Core_ilk_Proje.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
