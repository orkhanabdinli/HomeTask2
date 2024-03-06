using EternaMVC.DAL;
using EternaMVC.Models;
using EternaMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaMVC.Controllers;

public class HomeController : Controller
{
    string ClientsLabel = "Clients";
    string ClientsDesc = "Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.";
    private readonly EternaDbContext _context;

    public HomeController(EternaDbContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        List<Slider> sliders = _context.Sliders.ToList();
        List<Feature> features = _context.Features.ToList();
        List<About> abouts = _context.Abouts.ToList();
        List<Service> services = _context.Services.ToList();
        List<Clients> clients = _context.Clients.ToList();

        ViewBag.ClientsLabel=ClientsLabel;
        ViewBag.ClientsDesc=ClientsDesc;

        HomeViewModel viewModel = new HomeViewModel()
        {
            Sliders = sliders,
            Features = features,
            Abouts = abouts,
            Services = services,
            Clients = clients
        };
        return View(viewModel);
    }
}
