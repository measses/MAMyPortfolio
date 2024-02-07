using BussinesLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Areas.Admin.Controllers
{
	public class SocialMediaController : Controller
	{
		private ISocialMediaService _socialMediaService;

		public SocialMediaController(ISocialMediaService socialMedia)
		{
			_socialMediaService = socialMedia;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult SocialMediaAdd()
		{
			return View();
		}
		public IActionResult SocialMediaUpdate()
		{
			return View();
		}
		public IActionResult GetAll()
		{
			var values = _socialMediaService.TGetAll();
			return Json(values);
		}
		public IActionResult SocialMediaDelete()
		{
			return View();
		}
	}
}
