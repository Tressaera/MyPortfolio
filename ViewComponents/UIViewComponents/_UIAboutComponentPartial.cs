﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents.UIViewComponents;

public class _UIAboutComponentPartial : ViewComponent
{
    private readonly MyPortfolioContext _context;

    public _UIAboutComponentPartial(MyPortfolioContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var values = _context.TblAbouts.ToList();
        return View(values);
    }
}
