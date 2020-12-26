using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class CustomPizza : APizzaModel
  {
      public CustomPizza(){}
      public CustomPizza(Crust Crust, Size Size, List<Topping> Toppings)
        {
            this.Crust = Crust;
            this.Size = Size;
            this.Toppings = Toppings;
        }
  }
}