using BussinesLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.Portfolio;

public class PortfolioList : ViewComponent
{
    private readonly IPortfolioService _portfolio;

    public PortfolioList(IPortfolioService portfolio)
    {
        _portfolio = portfolio;
    }
    public IViewComponentResult Invoke()
    {
        var values = _portfolio.TGetAll();
        return View(values);
    }


}
