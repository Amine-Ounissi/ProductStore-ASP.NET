using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;
using System.Collections.Generic;
using System.Text;


namespace Data.Configurations
{
    public class FactureConfiguration : IEntityTypeConfiguration<Facture>
    {
        public void Configure(EntityTypeBuilder<Facture> builder)
        {
            builder.HasKey(f => new
            {
                f.DateAchat,
                f.ClientFk,
                f.ProductFk
            });

            builder.HasOne(f => f.Client)
            .WithMany(c => c.Factures)
            .HasForeignKey(f => f.ClientFk)
            .OnDelete(DeleteBehavior.Cascade); 

            builder.HasOne(f => f.Product)
            .WithMany(p => p.Facture)
            .HasForeignKey(f => f.ProductFk)
             .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}

