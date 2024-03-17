using EternaMVC.DAL;
using EternaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EternaMVC.Areas.Admin.Controllers;

[Area("admin")]
public class ServiceController(EternaDbContext _context) : Controller
{
    public IActionResult Index()
    {
        return View(_context.Services.ToList());
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Service service)
    {
        _context.Services.Add(service);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult Update(int id)
    {
        Service service = _context.Services.FirstOrDefault(x => x.Id == id);

        if (service == null) { throw new NullReferenceException(); }
        return View(service);
    }
    [HttpPost]
    public IActionResult Update(Service service)
    {
        Service existService = _context.Services.FirstOrDefault(x => x.Id == service.Id);

        if (service == null) { throw new NullReferenceException(); }
        existService.Title = service.Title;
        existService.Description = service.Description;
        service.IconName = service.IconName;
        _context.SaveChanges();
        return RedirectToAction("index");
    }
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var data = _context.Services.FirstOrDefault(x => x.Id == id);

        if (data == null) { throw new NullReferenceException(); }
        _context.Services.Remove(data);
        _context.SaveChanges();
        return RedirectToAction("index");
    }
}
