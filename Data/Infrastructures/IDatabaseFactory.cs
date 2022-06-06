using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Infrastructures
{   
    public interface IDataBaseFactory : IDisposable
    {
        PSContext DataContext { get; }
    }
}
