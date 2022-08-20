using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14_2021A.Models.Services
{
   public interface IProductService
    {
      List<Product> GetAll();
       void Add(Product product);
       Product GetById(long id);
       Product Update(long id, Product update);
       void Delete(long id);
    }
}
