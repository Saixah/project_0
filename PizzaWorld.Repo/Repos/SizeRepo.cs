using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Repo.Repos
{
    public class SizeRepo : SqlClient
    {
        public IEnumerable<Size> ReadSize()
        {
            return _db.Size;
        }

        public void DisplaySize()
        {
            DisplayItem(ReadSize());
        }

        public Size ReadOneSize(string Name)
        {
            return _db.Size.FirstOrDefault(s => s.name.Equals(Name));
        }

        public Size ReadOneSize(int UserInput)
        {
            return _db.Size.ToList().ElementAt(UserInput - 1);
        }

    }
}