using eCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Data
{

    public class DataContext : DbContext
    {
        /// <summary>
        /// you can pass the NAME of a connection string (e.g. stored in web.config).
        /// </summary>
        public DataContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
