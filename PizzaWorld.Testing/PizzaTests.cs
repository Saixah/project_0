using PizzaWorld.Domain.Models;
using Xunit;


namespace PizzaWorld.Testing
{
    public class PizzaTests
    {
        [Fact]
        private void Test_PizzaExists()
        {
            // arrange
            var sut = new Pizza();
            // act

            // assert
            Assert.IsType<Pizza>(sut);    
            Assert.NotNull(sut);        
        }
    }
}