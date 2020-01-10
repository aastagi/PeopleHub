using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;
using Microsoft.EntityFrameworkCore;
namespace Data
{
    public class DataContext : DbContext
    {    
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Favourite> Favourites { get; set; }
        public DbSet<MostVisited> MostVisited { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Favourite> Favourites { get; set; }

        public DbSet<Location>Locations { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

       
    }
}
