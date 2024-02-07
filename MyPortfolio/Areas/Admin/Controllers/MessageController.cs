using BussinesLayer.Services;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class MessageController : Controller
	{
		private IMessageService _messageService;

		public MessageController(IMessageService messageService)
		{
			_messageService = messageService;
		}

		public IActionResult Index()
		{
			return View();
		}
        [HttpGet]
        public IActionResult MessageAdd()
		{
			return View();
		}
        [HttpPost]
        public IActionResult MessageAdd(Message message)
		{
			_messageService.TAdd(message);
			return Ok();
		}

		public IActionResult MessageUpdate()
		{
			return View();
		}

		public IActionResult GetAll()
		{
			var values = _messageService.TGetAll();
			return Json(values);
		}

		public IActionResult MessageDelete(int id)
		{
            var values = _messageService.TGetById(id);
            _messageService.TRemove(values);
            return Ok();
        }
	}
}

