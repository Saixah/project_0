using PizzaWorld.Domain.Models;
using Xunit;


namespace PizzaWorld.Testing
{
    public class StoreTests
    {
        [Fact]
        private void Test_StoreExists()
        {
            // arrange
            var sut = new Store();
            // act

            // assert
            Assert.IsType<Store>(sut);    
            Assert.NotNull(sut);        
        }
    }
}