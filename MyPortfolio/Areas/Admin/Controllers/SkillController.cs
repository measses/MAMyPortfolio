using BussinesLayer.Services;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
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
        [HttpGet]
        public IActionResult SkillAdd()
		{
			return View();
		}
        [HttpPost]
        public IActionResult SkillAdd(Skill skill)
        {
            _skillService.TAdd(skill);
            return Ok();
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
		public IActionResult SkillDelete(int id)
		{
            var values = _skillService.TGetById(id);
            _skillService.TRemove(values);
            return Ok();
        }
	}
}
