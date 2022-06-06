using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Data.Infrastructures;
using Domain;
using ServicePattern;

namespace Service
{
    public class FactureService : Service<Facture>, IFactureService
    {
        public FactureService(IUnitOfWork utwk) : base(utwk)
        {
        }
        public List<Product> GetProdsByClient(Client c)
        {
            return GetMany().Where(f => f.ClientFk == c.CIN)
                .Select(f => f.Product).ToList();
        }
    }
}