using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Api_MVC.Models
{
    public class ProductReviewsContext : DbContext
    {
        public ProductReviewsContext() : base("name=ProductReviewsContext")
        {
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }

    }
}