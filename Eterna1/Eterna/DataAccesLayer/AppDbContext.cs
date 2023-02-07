using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.DataAccesLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<PircingService> PircingServices { get; set; }
        public DbSet<ServicePage> ServicePages { get; set; } 


    }
}
