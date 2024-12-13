using Microsoft.AspNetCore.Mvc;

namespace bhoodgrad.Controllers
{
    public class No : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
