using EternaMVC.DAL;
using EternaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EternaMVC.Areas.Admin.Controllers;

[Area("admin")]
public class SliderController(EternaDbContext _context) : Controller
{
    public IActionResult Index()
    {
        return View(_context.Sliders.ToList());
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Slider slider)
    {
        _context.Sliders.Add(slider);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult Update(int id) 
    {
        Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

        if (slider == null) { throw new NullReferenceException(); }
        return View(slider);
    }
    [HttpPost]
    public IActionResult Update(Slider slider)
    {
        Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);

        if (slider == null) { throw new NullReferenceException(); }
        existSlider.Title1 = slider.Title1;
        existSlider.Title2 = slider.Title2;
        existSlider.Desc = slider.Desc;
        existSlider.RedirectUrl = slider.RedirectUrl;
        existSlider.ImageUrl = slider.ImageUrl;
        _context.SaveChanges();
        return RedirectToAction("index");
    }
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var data = _context.Sliders.FirstOrDefault(x => x.Id == id);

        if (data == null) { throw new NullReferenceException(); }
        _context.Sliders.Remove(data);
        _context.SaveChanges();
        return RedirectToAction("index");
    }
}
