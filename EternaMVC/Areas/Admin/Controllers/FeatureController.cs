using EternaMVC.DAL;
using EternaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EternaMVC.Areas.Admin.Controllers;

[Area("admin")]
public class FeatureController(EternaDbContext _context) : Controller
{
    public IActionResult Index()
    {
        return View(_context.Features.ToList());
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Feature feature)
    {
        _context.Features.Add(feature);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult Update(int id)
    {
        Feature feature = _context.Features.FirstOrDefault(x => x.Id == id);

        if (feature == null) { throw new NullReferenceException(); }
        return View(feature);
    }
    [HttpPost]
    public IActionResult Update(Feature feature)
    {
        Feature existFeature = _context.Features.FirstOrDefault(x => x.Id == feature.Id);

        if (feature == null) { throw new NullReferenceException(); }
        existFeature.Title = feature.Title;
        existFeature.Desc = feature.Desc;
        existFeature.RedirectUrl = feature.RedirectUrl;
        existFeature.IconClass = feature.IconClass;
        _context.SaveChanges();
        return RedirectToAction("index");
    }
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var data = _context.Features.FirstOrDefault(x => x.Id == id);

        if (data == null) { throw new NullReferenceException(); }
        _context.Features.Remove(data);
        _context.SaveChanges();
        return RedirectToAction("index");
    }
}
