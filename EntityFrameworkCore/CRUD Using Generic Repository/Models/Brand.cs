using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14_2021A.Models.Base;

namespace WebApplication14_2021A.Models
{
    public class Brand :IEntityBase
    {
        [Key]
        [Display(Name = "Brand ID")]
        public long Id { get; set; }
        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Category Name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Category Name must between 2 and 10 chars")]
        public string BrandName { get; set; }
    }
}
