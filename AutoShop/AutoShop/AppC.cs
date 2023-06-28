using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoShop.DB;

namespace AutoShop
{
    internal class AppC : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Provider> Providers { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<DB.Type> Types { get; set; }

        public DbSet<Statuse> Statuse { get; set; }
        public AppC() : base("DefaultConnection") { }
    }
}
