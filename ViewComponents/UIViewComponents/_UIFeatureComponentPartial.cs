using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.ComponentModel;

namespace MyPortfolio.ViewComponents.UIViewComponents;

public class _UIFeatureComponentPartial : ViewComponent
{
    private readonly MyPortfolioContext _context;

    public _UIFeatureComponentPartial(MyPortfolioContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var values = _context.TblFeatures.FirstOrDefault();
        return View(values);
    }
}
