using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storage;
using Xunit;

namespace PizzaWorld.Testing
{
    public class StoresRepoTest
    {
        [Fact]
        private void Test_ReadList()
        {
            PizzaWorldContext _db = new PizzaWorldContext();
            Assert.NotNull(_db.Stores);
            Assert.IsType<List<Store>>(_db.Stores.ToList());
        }

        [Fact]
        private void Test_ReadOne()
        {
            PizzaWorldContext _db = new PizzaWorldContext();
            Assert.NotNull(_db.Stores);
            //just grab anyone
            Assert.IsType<Store>(_db.Stores.ToList().Last());
        }
    }

}