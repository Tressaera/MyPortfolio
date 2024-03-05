using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers;
public class AboutController : Controller
{
    private readonly MyPortfolioContext context;

    public AboutController(MyPortfolioContext dbMyPortfolioContext)
    {
        context = dbMyPortfolioContext;
    }

    public IActionResult Index()
    {
        var values = context.TblAbouts.ToList();
        return View(values);
    }
    [HttpGet]
    public IActionResult UpdateAbout(int id)
    {
        var values = context.TblAbouts.FirstOrDefault(x => x.AboutId == id);
        return View(values);
    }
    [HttpPost]
    public IActionResult UpdateAbout(TblAbout model)
    {
        var values = context.TblAbouts.FirstOrDefault(x => x.AboutId == model.AboutId);

        if (values != null)
        {
            values.Description = model.Description;
            values.Title = model.Title;
            values.Header = model.Header;
            values.ImageUrl = model.ImageUrl;

            // Değişiklikleri kaydedin
            context.SaveChanges();
        }
        return RedirectToAction("Index");
    }

}
