using BussinesLayer.Services;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Areas.Admin.Controllers
{
		[Area("Admin")]
		public class ContactController : Controller
		{
			private IContactService _contactService;

			public ContactController(IContactService contactservice)
			{
				_contactService = contactservice;
			}

			public IActionResult Index()
			{

				return View();
			}
        [HttpGet]
        public IActionResult ContactAdd()
			{
				return View();
			}
        [HttpPost]
        public IActionResult ContactAdd(Contact contact)
		{
			_contactService.TAdd(contact);
			return Ok();
		}
			public IActionResult ContactUpdate()
			{
				return View();
			}
			public IActionResult GetAll()
			{
				
				return Json(_contactService.TGetAll());
			}
			public IActionResult ContactDelete(int id)
			{
            var values = _contactService.TGetById(id);
            _contactService.TRemove(values);
			return Ok();

            }


		}

	}

