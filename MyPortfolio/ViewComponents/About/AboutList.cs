﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.About;

public class AboutList : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
