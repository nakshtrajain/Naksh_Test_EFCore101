using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore101.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore101.Data
{
    public class DemoContext : DbContext
    {
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<Product> Products {get; set;}
        public DbSet<ProductOrder> ProductOrders {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=TestDB;User Id=sa;Password=@Locked221;TrustServerCertificate=True;"
                );
        }
    }
}