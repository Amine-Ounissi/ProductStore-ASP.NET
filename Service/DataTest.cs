using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DataTest
    {
        public static List<Product> Products
        {
            get
            {
                Product acideCitrique = new Chemical()
                {
                    DateProd = new DateTime(2000, 12, 12),
                    Name = "ACIDE CITRIQUE",
                    Description = "Monohydrate - E330 - USP32",
                  
                    Price = 90,
                    Quantity = 30,
                    //ProductId = 1,
                    // City = "Sousse"
                };
                Product cacaoNaturelle = new Chemical()
                {
                    DateProd = new DateTime(2000, 12, 12),
                    Name = "POUDRE DE CACAO NATURELLE",
                    Description = "10% -12%",
                    
                    Price = 419,
                    Quantity = 80,
                    //ProductId = 2,
                    //City = "Sfax"
                };
                Product cacaoAlcalinisee = new Chemical()
                {
                    DateProd = new DateTime(2000, 12, 12),
                    Name = "POUDRE DE CACAO ALCALINISÉE",
                    Description = "10% -12%",
                   
                    Price = 60,
                    Quantity = 300,
                    //ProductId = 3,
                    //City = "Sfax"
                };
                Product dioxyde = new Chemical()
                {
                    DateProd = new DateTime(2000, 12, 12),
                    Name = "DIOXYDE DE TITANE",
                    Description = "TiO2 grade alimentaire, cosmétique et pharmaceutique.",
                    
                    Price = 200,
                    Quantity = 50,
                    //ProductId = 4,
                    //City = "Tunis"
                };
                Product amidon = new Chemical()
                {
                    DateProd = new DateTime(2000, 12, 12),
                    Name = "AMIDON DE MAÏS",
                    Description = "Amidon de maïs natif",
                   
                    Price = 70,
                    Quantity = 30,
                    //ProductId = 5,
                    // City = "Tunis"
                };
                Product blackberry = new Bilogical()
                {
                    DateProd = new DateTime(2000, 12, 12),
                    Name = "Blackberry",
                    Description = "",
                    
                    Price = 60,
                    //ProductId = 6,
                    Quantity = 0

                };
                Product apple = new Bilogical()
                {
                    DateProd = new DateTime(2000, 12, 12),
                    Description = "",
                    
                    Name = "Apple",
                    Price = 100.00,
                    //ProductId = 7,
                    Quantity = 100

                };

                return new List<Product>() { dioxyde, amidon, cacaoAlcalinisee, blackberry, apple, acideCitrique, cacaoNaturelle };
            }
        }


        public static List<Category> Categories
        {
            get
            {
                Category fruit = new Category() { Name = "Fruit" };
                Category Alimentaire = new Category() { Name = "Alimentaire" };
                return new List<Category> { fruit, Alimentaire };
            }
        }

        public static List<Provider> Providers
        {
            get
            {
                Provider sater = new Provider() { UserName = "SATER" };
                Provider sudMedical = new Provider() { UserName = "SUDMEDICAL" };
                Provider palliserSa = new Provider() { UserName = "Palliser SA" };
                Provider prov4 = new Provider() { UserName = "PROV4" };
                Provider prov5 = new Provider() { UserName = "PROV5", Email = "PROV5@esprit.tn" };
                return new List<Provider>() { sater, sudMedical, palliserSa, prov4, prov5 };
            }
        }

    }
}
