using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category:Concept
    {

        public int CategoryId { get; set; }
        public string Name{ get; set; }
        public virtual IList<Product> Products { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("Catégorie id:"+CategoryId+"\nCatégorie Name:"+Name+"\n");
        }
    }
}
