using BussinesLayer.Services;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
	{
		private IServiceService _serviceService;

		public ServiceController(IServiceService service)
		{
			_serviceService = service;
		}

		public IActionResult Index()
		{
			return View();
		}
        [HttpGet]

        public IActionResult ServiceAdd()
        {
            return View();
        }
        [HttpPost]

        public IActionResult ServiceAdd(Service service)
		{
            _serviceService.TAdd(service);
            return Ok();
        }
		public IActionResult ServiceUpdate()
		{
			return View();
		}
		public IActionResult GetAll()
		{
			var values = _serviceService.TGetAll();
			return Json(values);
		}
		public IActionResult ServiceDelete(int id)
		{
            var values = _serviceService.TGetById(id);
            _serviceService.TRemove(values);
            return Ok();
        }
	}
}
