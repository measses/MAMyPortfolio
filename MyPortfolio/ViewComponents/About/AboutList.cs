using BussinesLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.About;

public class AboutList : ViewComponent
{
    private readonly IAboutService _aboutService;
public AboutList(IAboutService aboutService)
    {
        this._aboutService = aboutService;
    }

    public IViewComponentResult Invoke()
    {
        var values = _aboutService.TGetAll();
        return View(values);
    }
}
