using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Abstracts
{
    public class APizzaModel : AEntity
    {
        public Crust Crust {get; set;}
        public Size Size {get; set;}
        public List<Topping> Toppings {get; set;}

        public APizzaModel()
        {
            AddCrust();
            AddSize();
            AddToppings();
        }

        protected virtual void AddCrust(){}
        protected virtual void AddSize(){}
        protected virtual void AddToppings(){}
    }
}