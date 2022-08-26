using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
         var pro = _context.Products.ToList();
            return Ok(pro);
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(long id )
        {
            var pro = _context.Products.Find(id);
            if (pro == null) return NotFound();
            return Ok(pro);
        }

        [HttpPost]
        public IActionResult PostProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }
        [HttpPut]
        public IActionResult PutProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return Ok(product);
        }
    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(long id)
        {
           var pro = _context.Products.Find(id);
            if (pro == null) return NotFound();
            _context.Products.Remove(pro);
            _context.SaveChanges();
            return Ok(pro);
        }

    }
}
