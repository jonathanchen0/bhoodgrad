using Microsoft.AspNetCore.Mvc;

namespace bhoodgrad.Controllers
{
    public class Yes : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
