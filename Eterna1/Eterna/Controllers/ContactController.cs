using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
