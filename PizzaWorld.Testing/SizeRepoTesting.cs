using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storage;
using Xunit;

namespace PizzaWorld.Testing
{
    public class SizeRepoTest
    {
        [Fact]
        private void Test_ReadList()
        {
            PizzaWorldContext _db = new PizzaWorldContext();
            Assert.NotNull(_db.Size);
            Assert.IsType<List<Size>>(_db.Size.ToList());
        }

        [Fact]
        private void Test_ReadOne()
        {
            PizzaWorldContext _db = new PizzaWorldContext();
            Assert.NotNull(_db.Size);
            //just grab anyone
            Assert.IsType<Size>(_db.Size.ToList().Last());
        }
    }

}