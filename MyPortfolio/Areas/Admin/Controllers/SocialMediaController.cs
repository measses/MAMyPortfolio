using BussinesLayer.Services;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
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
        [HttpGet]
        public IActionResult SocialMediaAdd()
		{
			return View();
		}
        [HttpPost]
        public IActionResult SocialMediaAdd(SocialMedia socialMedia)
        {
            _socialMediaService.TAdd(socialMedia);
            return Ok();
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
		public IActionResult SocialMediaDelete(int id)
		{
            var values = _socialMediaService.TGetById(id);
            _socialMediaService.TRemove(values);
            return Ok();
        }
	}
}
