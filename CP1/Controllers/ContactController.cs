using Microsoft.AspNetCore.Mvc;

namespace CP1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
