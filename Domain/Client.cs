using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Client
    {
        [Key]
        public int CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Mail { get; set; }
        //prop de navigation
        //public IList<Product> Products { get; set; }
        public virtual IList<Facture> Factures { get; set; }
    }
}
