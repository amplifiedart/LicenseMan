using LicenseMan.Models;
using LicenseMan.Services.Service;
using LicenseMan.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LicenseMan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonService _personService;

        public HomeController(ILogger<HomeController> logger, IPersonService personService)
        {
            _personService = personService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var count = _personService.Count();

            var model = new HomeDashboardViewModel { TotalPersons = count };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}