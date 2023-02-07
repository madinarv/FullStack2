using Eterna.DataAccesLayer;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class TeamController : Controller
    { private readonly AppDbContext _context;
        public TeamController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Teams>teams=_context.Teams.ToList();
            return View(teams);
        }
    }
}
