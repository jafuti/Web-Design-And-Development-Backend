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
        private readonly EcommerceDatabaseContext _context;
        public BrandController(EcommerceDatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            _context.Brands.ToList();
            return View();
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         