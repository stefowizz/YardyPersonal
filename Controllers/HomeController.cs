using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YardyRiver.Areas.Identity.Data;
using YardyRiver.Models;

namespace YardyRiver.Controllers
{
    //[Authorize] 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            this._userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewData["UserID"] = _userManager.GetUserId(this.User);
            return View();
        }

        public IActionResult Photo1()
        {
            return View();
        }

        public IActionResult Photo2()
        {
            return View();
        }

        
        public IActionResult Photo3()
        {
            return View();
        }

        public IActionResult Photo4() 
        {
            return View();
        }
        public IActionResult Independent()   
        {
            return View();
        }

        public IActionResult BlogPage() 
        {
            return View();
        }

        public IActionResult Gallery()  
        {
            return View();
        } 

        public IActionResult Community()
        {
            return View();
        }

        public IActionResult Adventure() 
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult AboutUS()
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
