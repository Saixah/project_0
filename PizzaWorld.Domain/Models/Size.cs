using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Size : AEntity
    {
        public string name { get; set; }
        public decimal price { get; set; }   

        public Size(){}
        public Size(string name)
        {
            this.name = name;
            this.price = price;
        }
    }
}