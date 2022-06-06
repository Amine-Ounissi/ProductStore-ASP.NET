using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Facture
    {
        public DateTime DateAchat { get; set; }
        public int ProductFk { get; set; }
        public int ClientFk { get; set; }
        public int Prix { get; set; }
       // [ForeignKey("ClientFK")]
        public virtual Client Client { get; set; }
       // [ForeignKey("ProductFk")]

        public virtual Product Product { get; set; }
    }
}
