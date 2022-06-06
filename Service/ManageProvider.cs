using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ManageProvider
    {
        private List<Provider> providers=new List<Provider>();
        public ManageProvider(List<Provider>providers)
        {
            this.providers =providers;
        }
     public IEnumerable<Provider> GetProviderByName(string name) { 
           var query=from p in providers
                  where p.UserName.Contains(name)
                  select p;
            return query;
            //return query.ToList();
        }
        public Provider GetFirstProviderByName(string name) {
            var query = from p in providers
                        where p.UserName.StartsWith(name)
                        select p;
            return query.First();


        }

        public Provider GetProviderById(int id)
        {
            var query = from p in providers
                        where p.Id==id
                        select p;
            return query.Single();


        }


    }
}
