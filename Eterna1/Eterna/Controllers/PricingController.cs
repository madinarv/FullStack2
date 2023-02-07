using Eterna.DataAccesLayer;
using Eterna.Models;
using Eterna.ViewModels;
using Eterna.ViewModels.PircingVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Pricing> Pricings = await _context.Pricings.Include(p => p.PircingServices).ToListAsync();
            IEnumerable<Service> Services = await _context.Services.ToListAsync();
            PircingVM pricingVM = new PircingVM
            {
                Pricings = Pricings,
                Services = Services
            };  
                                    
            return View();
        }
    }
}
