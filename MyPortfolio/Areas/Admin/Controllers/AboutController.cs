using BussinesLayer.Services;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
           
            return View();
        }
		[HttpGet]
		public IActionResult AboutAdd()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AboutAdd(About about, IFormFile image)
		{
            if (image != null && image.Length > 0)
            {

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }


                about.ImageUrl = "/images/" + fileName;
            }

            _aboutService.TAdd(about);
			return Ok();
		}
		public IActionResult AboutUpdate()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            var values = _aboutService.TGetAll();
            return Json(values);
        }
        public IActionResult AboutDelete( int id)
        {
            var values=_aboutService.TGetById(id);
            _aboutService.TRemove(values);
            return Ok();
        }


    }
}

