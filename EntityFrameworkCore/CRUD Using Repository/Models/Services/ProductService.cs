using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14_2021A.Models.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var actor = _context.Products.Find(id);
            _context.Remove(actor);
           _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
           var result = _context.Products.
                Include(c => c.Category).
                Include(b=>b.Brand).
                ToList();


            return result;
        }

        public Product GetById(long id)
        {
            var result = _context.Products.Find(id);

            return result;
            
        }

        public Product Update(long id, Product product)
        {

            _context.Update(product);
            _context.SaveChanges();
            return product;
            
        }
    }
    
}
