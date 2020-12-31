using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Topping : AEntity
    {
        //Nav
        public APizzaModel Pizza = new APizzaModel();
        public string name { get; set; }
        public decimal price { get; set; }
        public Topping(){}
        public Topping(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{name}";
        }
    }
}