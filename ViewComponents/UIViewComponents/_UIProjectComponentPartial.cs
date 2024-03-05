using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents.UIViewComponents;

public class _UIProjectComponentPartial : ViewComponent
{
    private readonly MyPortfolioContext _dbMyPortfolioContext;

    public _UIProjectComponentPartial(MyPortfolioContext dbMyPortfolioContext)
    {
        _dbMyPortfolioContext = dbMyPortfolioContext;
    }

    public IViewComponentResult Invoke()
    {
        var values = _dbMyPortfolioContext.TblProjects.ToList();
        return View(values);
    }
}
