using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace webAPIdemo2.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("name=DefaultConnection")
        {
        }
        public DbSet<Product> Products { get; set; }

    }
}