using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class CategoryController : Controller
    {
        //   = new EcommerceDatabaseContext();
        private readonly EcommerceDatabaseContext _context;
        public CategoryController(EcommerceDatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          var product = _context.Categories.ToList();
            return View(product);
        }
    }
}
