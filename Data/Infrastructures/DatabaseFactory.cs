using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Infrastructures
{
    public class DatabaseFactory : Disposable, IDataBaseFactory
    {
        private PSContext dataContext;
        public PSContext DataContext
        {
            get { return dataContext; }
        }
        public DatabaseFactory() { dataContext = new PSContext(); }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
