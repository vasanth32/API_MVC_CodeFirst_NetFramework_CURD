using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_MVC.Models
{
    public class ProductDetailsDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }

        public int Price { get; set; }

        public List<Review> Reviews { get; set; }
    }
}