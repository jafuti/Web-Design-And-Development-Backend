using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
        public RedirectResult Contact()
        {
            var url = "http://www.facebook.com";
            return Redirect(url);
        }
        public ContentResult Content()
        {
            return Content("Hello world", "text/xml");
        }
        public FileResult Download()
        {
            var path = "~/aspnetcoremvc.pdf";
            return File(path, "application/pdf");
        }
    }
}
