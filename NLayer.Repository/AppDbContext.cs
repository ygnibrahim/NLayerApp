using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Core;
using System.Reflection;

namespace NLayer.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet <Product> Products { get; set; }
        public DbSet <ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id=1,
                Color="Blue",
                Height=100,
                Witdh=40,
                ProductId=1
            }, new ProductFeature()
            {
                Id = 2,
                Color = "Red",
                Height = 60,
                Witdh = 55,
                ProductId = 2
            }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
