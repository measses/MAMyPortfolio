using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.Portfolio;

public class PortfolioList : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();  
    }
}
