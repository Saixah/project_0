using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class CustomPizza : APizzaModel
  {
    protected override void AddCrust(string _crust)
    {
      Crust = _crust;
    }

    protected override void AddSize(string _size)
    {
      Size = _size;
    }

    protected override void AddToppings(List<string> _toppings)
    {
      Toppings = new List<string>(_toppings);
    }
  }
}