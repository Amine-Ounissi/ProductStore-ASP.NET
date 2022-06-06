using Data;
using Data.Infrastructures;
using Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{

    public class CategoryService : Service <Category> ,ICategoryServie
    {
        public CategoryService(IUnitOfWork utwk) : base(utwk)
        {
        }

       
    }
}
