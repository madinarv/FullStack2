using Eterna.DataAccesLayer;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class AboutController : Controller
    {
         private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<About>abouts=_context.Abouts.ToList(); 
            return View(abouts);
        }
    }
}
