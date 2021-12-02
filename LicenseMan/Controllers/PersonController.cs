using LicenseMan.GeneralEntity;
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
			var persons = personService.GetAll().Select(person => new PersonIndexViewModel()
			{
				Id = person.Id,
				Name = person.Name,
				Role = person.Role
			});

			return View(persons);
		}

		[HttpGet]
		public IActionResult Create()
		{
			var model = new PersonEditViewModel();
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(PersonEditViewModel model)
		{
			if (ModelState.IsValid)
			{
				var person = new Person
				{
					Id = model.Id,
					Name = model.Name,
					Role = model.Role,
					Department = model.Department
				};
				await personService.CreateAsync(person);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			var person = personService.GetById(id);
			if (person == null)
				return NotFound();

			var model = new PersonEditViewModel
			{
				Id = person.Id,
				Name = person.Name,
				Role = person.Role,
				Department = person.Department
			};
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(PersonEditViewModel model)
		{
			if (ModelState.IsValid)
			{
				var person = personService.GetById(model.Id);

				if (person == null)
					return NotFound();


				person.Name = model.Name;
				person.Role = model.Role;
				person.Department = model.Department;

				await personService.UpdateAsync(person);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}

		[HttpGet]
		public IActionResult Detail(int Id)
		{
			var person = personService.GetById(Id);
			if (person == null)
				return NotFound();

			PersonDetailViewModel model = new PersonDetailViewModel
			{
				Id = person.Id,
				Name = person.Name,
				Role = person.Role,
				Department = person.Department
			};

			return View(model);
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			var person = personService.GetById(id);
			if (person == null)
				return NotFound();

			var model = new PersonDeleteViewModel
			{
				Id = person.Id,
				Name = person.Name
			};

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Delete(PersonDeleteViewModel model)
		{
			await personService.Delete(model.Id);
			return RedirectToAction(nameof(Index));
		}
	}
}
