using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14_2021A.Models;
using WebApplication14_2021A.Models.Services;

namespace WebApplication14_2021A.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _sevice;
        public CategoryController(ICategoryService service)
        {
            _sevice = service;
        }
        public async Task<IActionResult> Index()
        {
           var categoryData = await _sevice.GetAllAsync();
            return View(categoryData);
        }
        public async Task<IActionResult> Details(int id)
        {
            var categoryData = await _sevice.GetByIdAsync(id);
            return View(categoryData);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            await _sevice.AddAsync(category);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(long id)
        {
            var data = await _sevice.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(long id, Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            if (id == category.Id)
            {
                await _sevice.UpdateAsync(id, category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        public async Task<IActionResult> Delete(long id)
        {
            var data = await _sevice.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(long id)
        {
            var data = await _sevice.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            await _sevice.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
