using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Bilogical:Product
    {
        public string Herbs{ get; set; }
        public override void GetMyType()
        {
            System.Console.WriteLine("BILOGICAL");

        }
    }
    
}
