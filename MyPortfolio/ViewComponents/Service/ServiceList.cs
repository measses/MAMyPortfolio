using BussinesLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.Service;

public class ServiceList : ViewComponent
{
    private readonly IServiceService _serviceService;

    public ServiceList(IServiceService serviceService)
    {
        _serviceService = serviceService;
    }

    public IViewComponentResult Invoke()
    {
        var values = _serviceService.TGetAll();
        return View(values);
    }
}
