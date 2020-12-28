using System;
using System.Collections.Generic;
using PizzaWorld.Storage;

namespace PizzaWorld.Repo.Repos
{
    public abstract class SqlClient
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