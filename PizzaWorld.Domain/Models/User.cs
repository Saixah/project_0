using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class User : AEntity
    {
        public Store ChosenStore { get; set; }
        public List<Order> Orders { get; set; }
        public User()
        {
            Orders = new List<Order>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            int pizzaCount = 0;
            foreach (var p in Orders.Last().Pizzas)
            {
                pizzaCount++;
                sb.AppendLine("\n"+ pizzaCount +". "+ p.GetType().Name +": "+p.Size+ "," + p.Crust +" Crust with" );
                foreach(Topping toppings in p.Toppings)
                {
                    sb.Append("   "+toppings.name+"\n");
                }
            }

            return $"you have selected this store: {ChosenStore} and ordered these pizzas: {sb.ToString()}"; // string interpolation
        }
    }  
}