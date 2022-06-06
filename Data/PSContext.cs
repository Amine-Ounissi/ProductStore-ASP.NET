using Data.Configurations;
using Domain;
using Microsoft.EntityFrameworkCore;


using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Data
    {
        public class PSContext : DbContext
        {
            public PSContext()

            {
                // Database.EnsureCreated();
            }

            public PSContext(DbContextOptions options) : base(options)
            {

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AmineOunissiDB;Integrated Security=true");
            }
            public DbSet<Product> Products { get; set; }
            public DbSet<Provider> Providers { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Chemical> Chemicals { get; set; }
            public DbSet<Bilogical> Bilogicals { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                    modelBuilder.ApplyConfiguration(new ProductConfiguration());
                    modelBuilder.ApplyConfiguration(new CategoryConfiguration());
                    modelBuilder.ApplyConfiguration(new ChemicalConfiguration());
                    modelBuilder.ApplyConfiguration(new FactureConfiguration());

                //new ProductConfiguration().Configure(modelBuilder.Entity<Product>()); 2éme methode


                //modelBuilder.Entity<Product>().HasDiscriminator<int>("IsBiological")
                // .HasValue<Biological>(1).HasValue<Chemical>(2).HasValue<Product>(0);

                //modelBuilder.Entity<Biological>().ToTable("Biologicals");
                //modelBuilder.Entity<Chemical>().ToTable("Chemicals");

                //Configurer toute les propriétés de type string et dont le nom commence par “Name”

                foreach (var property in modelBuilder.Model.GetEntityTypes()

           .SelectMany(t => t.GetProperties())
           .Where(p => p.ClrType == typeof(string) &&

           p.Name.StartsWith("Name")))
                {
                    property.SetColumnName("MyName");
                }
            }
        }
}

    




