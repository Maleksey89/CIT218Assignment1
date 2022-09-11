using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string ID)
        {
             string seeView = ID;
            if (seeView == "cit")
               return View("cit218");
            else            
                return View();
            
        }

        //GET: Home
        public string   myIndex()
        {
            return "Maksim's MVCapp Index";
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
