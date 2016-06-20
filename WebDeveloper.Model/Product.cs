using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Product
    {
        public int ID { get; set; }

        [Display(Name = "Name Product")]
        [Required(ErrorMessage = "This field is required")]
        public string NameProduct { get; set; }

        [Display(Description = "Product description")]
        [Required(ErrorMessage = "This field is required")]
        public string Description { get; set; }

        [Display(Description = "Price Product")]
        [Required(ErrorMessage = "This field is required")]
        public decimal Price { get; set; }

        [Display(Description = "Amount in stock")]
        [Required(ErrorMessage = "This field is required")]
        public int Stock { get; set; }
    }
}
