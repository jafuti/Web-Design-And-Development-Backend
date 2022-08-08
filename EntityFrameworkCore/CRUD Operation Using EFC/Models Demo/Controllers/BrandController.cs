using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class BrandController : Controller
    {
        EcommerceDatabaseContext _context = new EcommerceDatabaseContext();
        public IActionResult Index()
        {
         var brands =   _context.Brands.ToList();
            return View(brands);
        }
    }
}
