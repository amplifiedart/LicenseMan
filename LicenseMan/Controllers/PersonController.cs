using LicenseMan.Models;
using LicenseMan.Services;
using Microsoft.AspNetCore.Mvc;

namespace LicenseMan.Controllers
{
	public class PersonController : Controller
	{
		private readonly IPersonService personService;

		public PersonController(IPersonService service)
		{
			personService = service;
		}

		public IActionResult Index()
		{
			var persons = personService.GetAll().Select(person => new PersonViewModel()
			{
				Id = person.Id,
				Name = person.Name,
				Role = person.Role
			});

			return View(persons);
		}
	}
}
