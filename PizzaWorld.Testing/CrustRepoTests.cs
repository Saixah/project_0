using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storage;
using Xunit;

namespace PizzaWorld.Testing
{
    public class CrustRepoTest
    {
        [Fact]
        private void Test_ReadCrust()
        {
            PizzaWorldContext _db = new PizzaWorldContext();
            Assert.NotNull(_db.Crust);
            Assert.IsType<List<Crust>>(_db.Crust.ToList());
        }

        [Fact]
        private void Test_ReadOne()
        {
            PizzaWorldContext _db = new PizzaWorldContext();
            Assert.NotNull(_db.Crust);
            //just grab anyone
            Assert.IsType<Crust>(_db.Crust.ToList().Last());
        }
    }

}