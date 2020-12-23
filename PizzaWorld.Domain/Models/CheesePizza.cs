using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class CheesePizza : APizzaModel
  {
    protected override void AddCrust()
    {
      Crust = new Crust();
      Crust.price = 2;
      Crust.name = "Thick";
    }

    protected override void AddSize()
    {
      Size = new Size();
      Size.price = 2;
      Size.name = "Large";
    }

    protected override void AddToppings()
    {
      Toppings = new List<Topping>
      {
        new Topping("Killme"),
        new Topping("Cheese")
      };
    }
  }
}