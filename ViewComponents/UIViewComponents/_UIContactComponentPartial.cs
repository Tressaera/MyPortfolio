﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents.UIViewComponents;

public class _UIContactComponentPartial : ViewComponent
{
    private readonly MyPortfolioContext _dbMyPortfolioContext;

    public _UIContactComponentPartial(MyPortfolioContext dbMyPortfolioContext)
    {
        _dbMyPortfolioContext = dbMyPortfolioContext;
    }
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
