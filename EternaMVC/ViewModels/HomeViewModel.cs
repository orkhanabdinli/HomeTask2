using EternaMVC.Models;

namespace EternaMVC.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders = new ();
        public List<Feature> Features = new ();
        public List<About> Abouts = new ();
        public List<Service> Services = new ();
        public List<Clients> Clients = new ();
    }
}
