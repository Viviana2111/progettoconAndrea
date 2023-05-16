using Microsoft.AspNetCore.Mvc;
using progettoconAndrea.Models;
using System.Diagnostics;
using progettoconAndrea.service;

namespace progettoconAndrea.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Interfacescrittaprova _scritta;

        public HomeController(ILogger<HomeController> logger, Interfacescrittaprova scritta)
        {
            _logger = logger;
            _scritta = scritta;
        }

        public IActionResult Index()
        {

            var scritta = _scritta.Prova("ciao");
            return View("Index", scritta);
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