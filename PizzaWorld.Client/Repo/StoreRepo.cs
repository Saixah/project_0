using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storage;

namespace PizzaWorld.Client.Repo
{
    public class StoreRepo : SqlClient
    {
        public IEnumerable<Store> ReadStores()
        {
            return _db.Stores;
        }

        public void DisplayStores()
        {
            DisplayItem(ReadStores());
        }
        
        public Store ReadOneStore(string Name)
        {
            //returns first of the name
            return _db.Stores.FirstOrDefault(s => s.Name == Name);
            //if repeats returns null
            // return _db.Stores.SingleOrDefault(s => s.Name == Name);
        }

        public Store ReadOneStore(int UserInt)
        {
            return _db.Stores.ToList().ElementAt(UserInt);
        }

        public void AddPizzaToStore(string StoreName)
        {
            var Store = _db.Stores.FirstOrDefault(s => s.Name == StoreName);
            Store.Pizzas.Add(new CheesePizza());
            _db.SaveChanges();
        }

        public List<APizzaModel> GetPizzasFromStore(string StoreName)
        {
            return ReadOneStore(StoreName).Pizzas;
        }

    }
}