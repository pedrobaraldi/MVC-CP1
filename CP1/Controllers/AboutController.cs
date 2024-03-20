using Microsoft.AspNetCore.Mvc;

namespace CP1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
