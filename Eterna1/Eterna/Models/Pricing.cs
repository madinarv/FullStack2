using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsFeatured { get; set; }
        public IEnumerable<PircingService> PircingServices { get; set; }
    }
}
