using PizzaWorld.Domain.Models;
using Xunit;


namespace PizzaWorld.Testing
{
    public class OrderTests
    {
        [Fact]
        private void Test_OrderExists()
        {
            // arrange
            var sut = new Order();
            // act

            // assert
            Assert.IsType<Order>(sut);    
            Assert.NotNull(sut);        
        }
    }
}