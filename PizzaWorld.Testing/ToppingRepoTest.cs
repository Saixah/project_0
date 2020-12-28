using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storage;
using Xunit;

namespace PizzaWorld.Testing
{
    public class ToppingRepoTest
    {
        [Fact]
        private void Test_ReadList()
        {
            PizzaWorldContext _db = new PizzaWorldContext();
            Assert.NotNull(_db.Topping);
            Assert.IsType<List<Topping>>(_db.Topping.ToList());
        }

        [Fact]
        private void Test_ReadOne()
        {
            PizzaWorldContext _db = new PizzaWorldContext();
            Assert.NotNull(_db.Topping);
            //just grab anyone
            Assert.IsType<Topping>(_db.Topping.ToList().Last());
        }
    }

}