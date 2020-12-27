using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Repo
{
    public class ToppingRepo : SqlClient
    {
        public IEnumerable<Topping> ReadToppings()
        {
            return _db.Topping;
        }

        public Topping ReadOneTopping(int UserInt)
        {
            return _db.Topping.ToList().ElementAt(UserInt - 1);
        }

        public void DisplayToppings()
        {
            DisplayItem(ReadToppings());
        }

        public Topping ReadOneTopping(string Name)
        {
            return _db.Topping.FirstOrDefault(s => s.name.Equals(Name));
        }
    }
}