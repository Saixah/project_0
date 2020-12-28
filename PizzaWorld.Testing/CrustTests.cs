using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class CrustTests
    {
        [Fact]
        private void Test_CrustExists()
        {
            var crust = new Crust();
            Assert.IsType<Crust>(crust);
            Assert.NotNull(crust);
        }
    }

}
