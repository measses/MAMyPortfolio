using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.Service;

public class ServiceList : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
