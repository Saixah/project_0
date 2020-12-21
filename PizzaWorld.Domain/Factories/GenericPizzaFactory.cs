using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Factories
{
  class GenericPizzaFactory
  {
    public T Make<T>() where T : APizzaModel, new()
    {
      return new T();
    }

    public T Make<T>(string Size, string Crust, List<string> Toppings) where T : APizzaModel, new()
    {
      return new T();
    }
  }
}