using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Crust : AEntity
    {
        public string name { get; set; }
        public decimal price { get; set; }

        public Crust(){}
        public Crust(string name)
        {
            this.name = name;
            this.price = price;
        }
    }
}