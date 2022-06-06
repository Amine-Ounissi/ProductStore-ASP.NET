using Data;
using Data.Infrastructures;
using Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork utwk) : base(utwk)
        {

        }
        public void DeleteOldProducts()
        {
            var now = DateTime.Now;
            var products =
                GetMany()
                .Where(p => now.Subtract(p.DateProd).TotalDays > 365);

            foreach (var item in products)
            {
                Delete(item);
            }
            Commit();
        }

        public List<Product> FindMost5ExpensiveProds()
        {
            return GetMany().OrderByDescending(p => p.Price)
                 .Take(5).ToList();
        }

        public double UnavailableProductsPercentage()
        {
            var count = GetMany().Where(p => p.Quantity == 0).Count();
            return (double)count / GetMany().Count() * 100;
        }
    }
}

