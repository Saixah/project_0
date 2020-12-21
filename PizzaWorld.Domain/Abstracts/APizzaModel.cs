using System.Collections.Generic;

namespace PizzaWorld.Domain.Abstracts
{
    public abstract class APizzaModel
    {
        public string Crust {get; set;}
        public string Size {get; set;}
        public List<string> Toppings {get; set;}

        protected APizzaModel()
        {
            AddCrust();
            AddSize();
            AddToppings();
        }
        protected APizzaModel(string Crust, string Size, List<string> Toppings)
        {
            AddCrust(Crust);
            AddSize(Size);
            AddToppings(Toppings);
        }

        protected virtual void AddCrust(){}
        protected virtual void AddCrust(string CrustInput){}
        protected virtual void AddSize(){}
        protected virtual void AddSize(string SizeInput){}
        protected virtual void AddToppings(){}
        protected virtual void AddToppings(List<string> ToppingInput){}
    }
}