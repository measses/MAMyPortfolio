using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.Contact;

public class ContactList: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
