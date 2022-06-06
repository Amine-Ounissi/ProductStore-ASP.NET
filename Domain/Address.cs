using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{[Owned]
    public class Address
    {
        public string StreetAddress { set; get; }
        public string City { set; get; }

    }
}
