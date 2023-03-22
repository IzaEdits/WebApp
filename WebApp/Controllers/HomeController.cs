using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        //atributo da classe HomeController
        private readonly ILogger<HomeController> _logger;

        //construtor da classe
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Action Result devolve uma tela (html)
        public IActionResult Index()
        {
            return View();
        }

        //Mais uma tela no sistema
        public IActionResult BemVindo()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
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