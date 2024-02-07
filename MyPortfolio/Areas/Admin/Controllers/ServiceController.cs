using BussinesLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Areas.Admin.Controllers
{
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
		public IActionResult ServiceAdd()
		{
			return View();
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
		public IActionResult ServiceDelete()
		{
			return View();
		}
	}
}
