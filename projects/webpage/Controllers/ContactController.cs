using Microsoft.AspNetCore.Mvc;

namespace webpage.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
