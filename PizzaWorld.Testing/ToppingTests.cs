using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class ToppingTests
    {
        [Fact]
        private void Test_ToppingExists()
        {
            var top = new Topping();
            Assert.IsType<Topping>(top);
            Assert.NotNull(top);
        }
    }

}
