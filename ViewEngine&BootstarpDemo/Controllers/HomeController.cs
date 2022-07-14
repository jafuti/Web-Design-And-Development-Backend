using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentDetails()
        {
            ViewBag.Id = 101;
            ViewBag.Name = "Abebe";
            ViewBag.Mark = 80;
            ViewBag.Course = new List<string>()
            {
                "java","php", ".Net"
            };
            return View();
        }
    }
}
