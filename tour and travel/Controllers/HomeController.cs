using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tour_and_travel.Models;

namespace tour_and_travel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) => _logger = logger;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult servies()
        {
            return View();
        }

        public IActionResult packages()
        {
            return View();
        }
        public IActionResult review()
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
