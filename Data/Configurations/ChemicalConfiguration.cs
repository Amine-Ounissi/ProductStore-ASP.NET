using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class ChemicalConfiguration : IEntityTypeConfiguration<Chemical>
    {

        public void Configure(EntityTypeBuilder<Chemical> builder)
        {
            builder.OwnsOne(ch => ch.MyAdress,
                            addr =>
                            {
                                addr.Property(add => add.StreetAddress)
                                    .HasColumnName("MyAddress")
                                    .HasMaxLength(50);
                                addr.Property(add => add.City)
                                    .IsRequired()
                                    .HasColumnName("MyCity");
                            }
                           );
        }
    }
}
