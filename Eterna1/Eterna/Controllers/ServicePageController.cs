using Eterna.DataAccesLayer;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers
{
    public class ServicePageController : Controller
    {
        private readonly AppDbContext _context;
        public ServicePageController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<ServicePage> servicePages = await _context.ServicePages.ToListAsync();
            return View(servicePages);
        }
    }
}
