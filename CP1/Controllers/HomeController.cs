using Microsoft.AspNetCore.Mvc;

namespace CP1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
