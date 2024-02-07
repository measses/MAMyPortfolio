using BussinesLayer.Services;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
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
        [HttpGet]
        public IActionResult PortfolioAdd()
		{
			return View();
		}
        [HttpPost]
        public IActionResult PortfolioAdd(Portfolio portfolio)
		{
            _portfolioService.TAdd(portfolio);
            return Ok();
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
		public IActionResult PortfolioDelete(int id)
		{
            var values = _portfolioService.TGetById(id);
            _portfolioService.TRemove(values);
            return Ok();
        }
	}
}
