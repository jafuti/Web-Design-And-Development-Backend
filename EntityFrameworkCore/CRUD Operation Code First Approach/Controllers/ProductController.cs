using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14_A.Models;
using WebApplication14_A.Models.Services;

namespace WebApplication14_A.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
          var data = _service.GetAll();
            return View(data);
        }
       
    }
}
