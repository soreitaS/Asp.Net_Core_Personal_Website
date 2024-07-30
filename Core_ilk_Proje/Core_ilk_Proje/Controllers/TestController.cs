using Microsoft.AspNetCore.Mvc;

namespace Core_ilk_Proje.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
