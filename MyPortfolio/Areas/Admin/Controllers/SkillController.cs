using BussinesLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Areas.Admin.Controllers
{
	public class SkillController : Controller
	{
		private ISkillService _skillService;

		public SkillController(ISkillService skillService)
		{
			_skillService = skillService;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult SkillAdd()
		{
			return View();
		}
		public IActionResult SkillUpdate()
		{
			return View();
		}
		public IActionResult GetAll()
		{
			var values = _skillService.TGetAll();
			return Json(values);
		}
		public IActionResult SkillDelete()
		{
			return View();
		}
	}
}
