using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14_2021A.Models;
using WebApplication14_2021A.Models.Services;

namespace WebApplication14_2021A.Controllers
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
         var data =   _service.GetAll();
            return View(data);
        }
        public IActionResult Details(long id)
        {
            var data = _service.GetById(id);
            if (data == null) return View("NotFound");
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _service.Add(product);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(long id)
        {
           var data =_service.GetById(id);
            if (data == null) return View("NotFound");
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(long id, Product product)
        {
            _service.Update(id,product);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(long id)
        {
            var data = _service.GetById(id);
            if (data == null) return View("NotFound");
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(long id)
        {
            var data = _service.GetById(id);
            if (data == null) return View("NotFound");
             _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
