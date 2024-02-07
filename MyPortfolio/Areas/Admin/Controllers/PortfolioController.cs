using BussinesLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Areas.Admin.Controllers
{
	public class PortfolioController : Controller
	{
		private IPortfolioService _portfolioService;

		public PortfolioController(IPortfolioService portfolioService)
		{
			_portfolioService = portfolioService;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult PortfolioAdd()
		{
			return View();
		}
		public IActionResult PortfolioUpdate()
		{
			return View();
		}
		public IActionResult GetAll()
		{
			var values = _portfolioService.TGetAll();
			return Json(values);
		}
		public IActionResult PortfolioDelete()
		{
			return View();
		}
	}
}
