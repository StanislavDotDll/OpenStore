using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OpenStore.Model
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
