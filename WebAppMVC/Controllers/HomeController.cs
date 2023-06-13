using App.Core.Entities;
using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Demo()
        {
            return View();
        }

        //public IActionResult InBox  ()
        //{
        //    return RedirectToAction("Index");
        //}

        public IActionResult Index()
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