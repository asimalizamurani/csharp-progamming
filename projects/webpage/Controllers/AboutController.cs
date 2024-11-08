using Microsoft.AspNetCore.Mvc;

namespace webpage.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
