using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YardyRiver.Models;

namespace YardyRiver.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult YardyRiverTubing() 
        {
            return View();
        }

        public IActionResult YardyHorsebackRide() 
        {
            return View();
        }

        public IActionResult YardyParkLife() 
        {
            return View();
        }

        public IActionResult Breezy() 
        {
            return View();
        }

        public IActionResult YardyRiverWalk()   
        {
            return View();
        }

        public IActionResult Adventure() 
        {
            return View();
        }

        public IActionResult Services() 
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
