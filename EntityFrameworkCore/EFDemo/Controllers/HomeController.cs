using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    
        public IActionResult Contact()
        {
            ViewBag.Phone = 44444444;
            return View();
        }
        public IActionResult StudentDetails()
        {
            ViewBag.Id = 101;
            ViewBag.Name = "Abebe";
            ViewBag.Mark = 70;
            ViewBag.Course = new List<string>()
            {
                ".Net", "PHP","Java"
            };
            return View();
        }
    }
}
