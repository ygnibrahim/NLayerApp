using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                ID = 1 ,
                CategoryId=1,
                Name = "Kalem 1" ,
                Price =100,
                Stock =300,
                CreateDate = DateTime.Now,
            },
            new Product
            {
                ID = 2,
                CategoryId = 1,
                Name= "Kalem 2",
                Price = 10,
                Stock = 350,
                CreateDate = DateTime.Now,
            },
            new Product
            {
                ID = 3,
                CategoryId = 1,
                Name="Kalem 3",
                Price = 400,
                Stock = 350,
                CreateDate = DateTime.Now,
            },
            new Product
            {
                ID = 4, 
                CategoryId = 2,
                Name = "Kitap 1",
                Price = 200,
                Stock = 650,
                CreateDate = DateTime.Now,
            }
            ); 
        }
    }
}
