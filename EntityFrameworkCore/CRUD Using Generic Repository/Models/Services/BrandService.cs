using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14_2021A.Models.Base;

namespace WebApplication14_2021A.Models.Services
{
    public class BrandService: EntityBaseRepository<Brand>,IBrandService
    {
        private readonly ApplicationDbContext _context;
        public BrandService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
