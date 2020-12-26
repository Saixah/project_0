using System;
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storage;

namespace PizzaWorld.Client
{
    public class SqlClient
    {
        protected readonly PizzaWorldContext _db = new PizzaWorldContext();

        protected void DisplayItem<T>(IEnumerable<T> List)
        {
            foreach (T item in List)
            {
                Console.WriteLine(item);
            }
        }
    }
}