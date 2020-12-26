using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Store : AEntity
    {
        public List<Order> Orders {get; set;}
        public List<APizzaModel> Pizzas {get;set;}
        public string Name {get; set;}

        public void CreateOrder()
        {
            Orders.Add(new Order());
        }
        public Store()
        {
            Orders = new List<Order>();
        }

        public Store(string name, List<Order> orders, List<APizzaModel> pizzaModels)
        {
            this.Name = name;
            this.Orders = orders;
            this.Pizzas = pizzaModels;
        }
        bool DeleteOrder(Order order)
        {
            try
            {
                Orders.Remove(order);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}