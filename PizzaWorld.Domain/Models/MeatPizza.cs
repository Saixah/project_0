using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class MeatPizza : APizzaModel
  {
    protected override void AddCrust()
    {
      Crust = new Crust("MOVetTHisTEstTOTesting");
    }

    protected override void AddSize()
    {
      Size = new Size("Large");
    }

    protected override void AddToppings()
    {
      Toppings = new List<Topping>
      {
       new Topping("test"),
       new Topping("test1"),
       new Topping("test2")
      };
    }
  }
}