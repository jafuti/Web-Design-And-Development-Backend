using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product{Id=101, ProductName="Iphone", Price=100},
                new Product{Id=102, ProductName="Smasung", Price=200},
                new Product{Id=103, ProductName="Huwei", Price=300},
            };
          //  ViewBag.product = products;
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var products = new List<Product>()
            {
                new Product{Id=101, ProductName="Iphone", Price=100},
                new Product{Id=102, ProductName="Smasung", Price=200},
                new Product{Id=103, ProductName="Huwei", Price=300},
            };
            Product matchingproduct = null;
            foreach(var item in products)
            {
                if (item.Id == id)
                {
                    matchingproduct = item;
                }
            }

         //   ViewBag.pro = matchingproduct;
            return View(matchingproduct);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create( [Bind("Id, ProductName")] Product product)
        {
            return View();
        }
    }
}
