using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations

{
        public class ProductConfiguration : IEntityTypeConfiguration<Product>
        {
        public void Configure(EntityTypeBuilder<Product> builder)
            {
                //Many to Many
                builder.HasMany<Provider>(p => p.Providers)
                  .WithMany(v => v.Products)
                  .UsingEntity(j => j.ToTable("Providings"));//Table d'association
           
                 //One to Many            
                 builder.HasOne<Category>(p => p.MyCategory)
                  .WithMany(c => c.Products)//the values of foreignkey
                  .HasForeignKey(p => p.CategoryId);

            // builder.HasDiscriminator<int>("IsBiological")
            // .HasValue<Bilogical>(1)
            // .HasValue<Chemical>(2)
            // .HasValue<Product>(0);
        }
    }
    
}
