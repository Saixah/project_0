using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class SizeTests
    {
        [Fact]
        private void Test_SizeExists()
        {
            var size = new Size();
            Assert.IsType<Size>(size);
            Assert.NotNull(size);
        }
    }

}
