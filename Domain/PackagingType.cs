using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public enum PackagingType
    {
        [Display(Name = "Carton")]
        Carton = 0,
        [Display(Name = "Plastic")]
        Plastic = 1
    }
}
