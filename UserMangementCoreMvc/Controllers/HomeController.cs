using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserMangementCoreMvc.Models;

namespace UserMangementCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        //dependency Injection//
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Get value in Session object.
            string name = HttpContext.Session.GetString("Name");
            return View(model:name);
        }

        public IActionResult Data()
        {
            TempData["message"] = DateTime.Now;
            return View();
        }
        public IActionResult SecondData()
        {
            return View();
        }
        public IActionResult SaveName(string name)
        {
            //Set value in Session object.
            HttpContext.Session.SetString("Name", name);
            return RedirectToAction("Index");

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