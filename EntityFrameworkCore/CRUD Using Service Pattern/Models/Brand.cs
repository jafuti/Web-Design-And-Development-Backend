using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14_2021A.Models
{
    public class Brand
    {
        [Key]
        public long BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
