using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.DAL.Configuraions
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //mapping
           builder.HasOne(x=>x.Category).WithMany(x=>x.products).HasForeignKey(x=>x.CategoryId);
            //prop
            builder.Property(x=>x.ProductName).HasMaxLength(256);
            builder.Property(x => x.ProductName).IsRequired();
            builder.Property(x => x.ImagePath).HasMaxLength(256);
            builder.Property(x => x.UnitPrice).HasColumnType("money");

            builder.HasData(SeedProductData());
        }

        private List<Product> SeedProductData()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,ProductName="nike airmax", UnitPrice=400,UnitsInStock=500,CategoryId=1},
                new Product{Id=2,ProductName="lenova", UnitPrice=20000,UnitsInStock=250,CategoryId=2},
                new Product{Id=3,ProductName="MAC Ruj", UnitPrice=2000,UnitsInStock=250,CategoryId=3}
            };
            return products;
        }

    }
}
