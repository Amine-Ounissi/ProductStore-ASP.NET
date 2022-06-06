using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ManageProductcs
    {
        private List<Product> products = new List<Product>();
        public ManageProductcs(List<Product> products)
        {
            this.products = products;
        }

        public IEnumerable<Product> Get5Chemical(double price) { 
        
        var query= from p in products.OfType<Chemical>()
                   where p.Price > price 
                   //&& p is Chemical 
                   select p;
            return query.Take(5);
        
        }

        public IEnumerable<Product> GetProductPrice(double price)
        {

            var query = from p in products
                        where p.Price > price
                        //&& p is Chemical 
                        select p;
            return query.Skip(2);

        }
        public double GetAveragePrice() {
            var query = from p in products
                        select p.Price;
            return query.Average();

        }

        public Product GetMaxPrice()
        {
            var query = from p in products
                        select p.Price;
            double max=query.Max();
            var query1 = from p in products
                         where (p.Price >= max)
                        select p;
            return query1.First();
        }

        public int GetCountProduct(string city) {
            var query= from p in products.OfType<Chemical>()
                       where (p.MyAdress.City == city)
                       select p;
            return query.Count();
        
        
        
        }
        public IEnumerable<Product> GetChemicalCity()
        {

            var query = from p in products.OfType<Chemical>()
                        orderby p.MyAdress.City descending
                        select p;
            return query;

        }

        public IEnumerable<IGrouping<string,Chemical>>GetChemicalGroupByCity()
        {

            var query = from pr in products.OfType<Chemical>()
                        orderby pr.MyAdress.City
                        group pr by pr.MyAdress.City;
                        
            return query;

        }

        public void DisplayChemicalGroupByCity()
        {

            var query = from pr in products.OfType<Chemical>()
                        orderby pr.MyAdress.City
                        group pr by pr.MyAdress.City;
            foreach (var item in query) 
            {
                Console.WriteLine(item.Key);
                foreach (var ch in item)
                    ch.GetDetails();
             }
            

        }

    }
}
