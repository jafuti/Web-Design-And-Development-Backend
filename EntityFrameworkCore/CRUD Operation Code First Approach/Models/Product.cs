﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14_A.Models
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public string AvailabilityStatus { get; set; }
        public long? CategoryId { get; set; }
        public long? BrandId { get; set; }
        public bool? Active { get; set; }


        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        }
}
