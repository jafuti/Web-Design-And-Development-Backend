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
        public async Task<IActionResult> Index()
        {
         var data =   await _service.GetAllAsync();
            return View(data);
        }
        public async Task<IActionResult> Details(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View(data);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            await _service.AddAsync(product);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(long id)
        {
           var data = await _service.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(long id, Product product)
        {
            await _service.UpdateAsync(id,product);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return View("NotFound");
             await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
