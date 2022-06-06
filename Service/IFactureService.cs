using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using ServicePattern;

namespace Service
{
    public interface IFactureService : IService<Facture>
    {
        public List<Product> GetProdsByClient(Client c);
    }
}
