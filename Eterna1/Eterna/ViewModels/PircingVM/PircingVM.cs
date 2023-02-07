using Eterna.Models;

namespace Eterna.ViewModels.PircingVM
{
    public class PircingVM
    {
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Pricing> Pricings { get; set; }

    }
}
