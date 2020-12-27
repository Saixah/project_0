using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Repo
{
    public class CrustRepo : SqlClient
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

        public Crust ReadOneCrust(int UserInput)
        {
            return _db.Crust.ToList().ElementAt(UserInput - 1);
        }
    }
}