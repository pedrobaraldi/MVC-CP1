using Microsoft.AspNetCore.Mvc;

namespace CP1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
