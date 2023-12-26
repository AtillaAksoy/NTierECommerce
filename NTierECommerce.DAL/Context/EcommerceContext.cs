using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NTierECommerce.DAL.Configuraions;
using NTierECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.DAL.Context
{
    public class EcommerceContext:IdentityDbContext<AppUser,AppUserRole,int>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //entity ler için özelleştirme
            //builder.Entity<AppUser>().Property(x => x.Adress).HasMaxLength(500);
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new AppUserRoleConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlServer("server=KDK-101-PC55-YZ;database=EcommerceDBN;Trusted_Connection=True;TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
