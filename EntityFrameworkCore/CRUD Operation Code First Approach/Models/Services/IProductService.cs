using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14_A.Models.Services
{
  public  interface IProductService
    {
     List<Product> GetAll();
        void Add(Product product);
       Product GetById(long id);
        Product Update(Product product);
      void Delete(long id);
    }
}
