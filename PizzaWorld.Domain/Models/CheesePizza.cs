using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class CheesePizza : APizzaModel
  {
    protected override void AddCrust()
    {
      Crust = new Crust();
    }

    protected override void AddSize()
    {
      Size = new Size();
    }

    protected override void AddToppings()
    {
      Toppings = new List<Topping>();
    }
  }
}