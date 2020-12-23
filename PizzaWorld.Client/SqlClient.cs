using System.Collections.Generic;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storage;

namespace PizzaWorld.Client
{
    public class SqlClient
    {
        private readonly PizzaWorldContext _db = new PizzaWorldContext();
        public IEnumerable<Store> ReadStores()
        {
            return _db.Stores;
        }
    }
}