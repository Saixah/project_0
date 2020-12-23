using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Topping : AEntity
    {
        public string name { get; set; }
        public decimal price { get; set; }

        public Topping(){}
        public Topping(string name)
        {
            this.name = name;
            this.price = price;
        }
    }
}