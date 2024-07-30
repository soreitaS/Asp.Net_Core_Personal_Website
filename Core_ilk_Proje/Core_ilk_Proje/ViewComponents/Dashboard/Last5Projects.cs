using Microsoft.AspNetCore.Mvc;

namespace Core_ilk_Proje.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
