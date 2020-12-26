using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storage;

namespace PizzaWorld.Client.Repo
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

    }
}