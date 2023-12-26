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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x=>x.CategoryDescription).HasMaxLength(500);
            builder.Property(x => x.CategoryDescription).IsRequired();

            //Seed Data
            builder.HasData(SeedCategoryData());
        }

        private List<Category> SeedCategoryData() 
        {
            List<Category> categories = new List<Category>()
            {
                new Category{Id=1,CategoryName="giyim",CategoryDescription="yazlık kışlık renkli renksiz giyim ürünleri"},
                new Category{Id=2,CategoryName="teknoloji",CategoryDescription="tablet telefon ürünleri"},
                new Category{Id=3,CategoryName="kozmetik",CategoryDescription="parfüm makyaj ürünleri"}
            };
            return categories;
        }

    }
}
