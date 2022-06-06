using Data;
using Microsoft.Extensions.DependencyInjection;
using Domain;
using Service;
using Microsoft.EntityFrameworkCore;

using S = System; //~ import System; 
using System.Collections.Generic;
using System.Linq;
using Data.Infrastructures;

namespace Console
{
    internal class Program
    {
     
static void Main(string[] args) // le point d'entré de notre application
{
    var serviceProvider = new ServiceCollection()
        .AddScoped<ICategoryServie, CategoryService>()
        .AddTransient<IUnitOfWork, UnitOfWork>()
        .AddSingleton<IDataBaseFactory, DatabaseFactory>()
        .BuildServiceProvider();

    var categoryService = serviceProvider.GetService<ICategoryServie>();

    categoryService.Add(DataTest.Categories[0]);
    categoryService.Commit();
}

public static void ChangeValue(ref int myParam, params int[] t)
{
    S.Random rd = new S.Random();
    myParam = rd.Next(100, 200);
    S.Console.WriteLine("la valeur de myParam est: " + myParam);
}
    }
}

