using Microsoft.AspNetCore.Mvc;

namespace bhoodgrad.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
