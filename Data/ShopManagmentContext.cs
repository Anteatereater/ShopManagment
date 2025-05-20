using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class ShopManagmentContext:DbContext
    {
        public ShopManagmentContext() : base() { }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<ShopCustomer> ShopCustomers { get; set; }
        public DbSet<ShopProduct> ShopProducts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//Catalog=ShopManagment
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=MSSQLLocalDB;Initial Catalog=ShopManagment;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
        }
    }
}
