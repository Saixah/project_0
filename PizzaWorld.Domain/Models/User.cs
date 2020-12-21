using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaWorld.Domain.Models
{
    public class User
    {
        public User()
        {
            Orders = new List<Order>();
        }
        public Store ChosenStore { get; set; }
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var p in Orders.Last().Pizzas)
            {
                sb.AppendLine(p.ToString());
            }

            return $"you have selected this store: {ChosenStore} and ordered these pizzas: {sb.ToString()}"; // string interpolation
        }
    }  
}