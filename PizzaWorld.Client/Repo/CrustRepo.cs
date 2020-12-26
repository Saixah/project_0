using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storage;

namespace PizzaWorld.Client.Repo
{
    public class Crust : SqlClient
    {
        public IEnumerable<Crust> ReadCrust()
        {
            return _db.Crust;
        }

        public void DisplayCrust()
        {
            DisplayItem(ReadCrust());
        }

        public Crust ReadOneCrust(string Name)
        {
            return _db.Crust.FirstOrDefault(s => s.name.Equals(Name));
        }
    }
}