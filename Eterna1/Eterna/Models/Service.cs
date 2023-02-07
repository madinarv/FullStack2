using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.Models
{
    public class Service
    {
        public int Id { get; set; }
        [StringLength(255)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        public IEnumerable<PircingService> PircingServices { get; set; }
    }
}
