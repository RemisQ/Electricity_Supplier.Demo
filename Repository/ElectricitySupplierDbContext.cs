using Electricity_Supplier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Supplier.DataAccess
{
    public class ElectricitySupplierDbContext : DbContext
    {
        public DbSet<PointOfSale> PointOfSales { get; set; }
        public DbSet<SalesManager> SalesManagers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Contract> Contracts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=Electricity_Supplier;Integrated Security=True");
        }
    }
}
