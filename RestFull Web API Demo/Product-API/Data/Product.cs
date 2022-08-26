using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_API.Data
{
    public class Product
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
    }
}
