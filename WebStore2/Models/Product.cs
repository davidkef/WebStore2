using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Give the product a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Describe the product")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Pick a category")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Price has to be more then 0")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Stock has to be atleast 1")]
        public int Stock { get; set; }
    }
}