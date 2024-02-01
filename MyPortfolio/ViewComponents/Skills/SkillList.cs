using BussinesLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.Skills;

public class SkillList : ViewComponent
{
    private readonly ISkillService _skills;

    public SkillList(ISkillService skills)
    {
        _skills = skills;
    }

    public IViewComponentResult Invoke()
    {
        var values = _skills.TGetAll();
        return View(values);
    }
}
