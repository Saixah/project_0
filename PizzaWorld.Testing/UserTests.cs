using System.Collections.Generic;
using PizzaWorld.Domain.Models;
using Xunit;


namespace PizzaaWorld.Testing
{
    public class UserTests
    {
        [Fact]
        private void Test_UserExists()
        {
            // arrange
            var sut = new User();
            // act

            // assert
            Assert.IsType<User>(sut);    
            Assert.NotNull(sut);        
        }

        [Fact]
        private void Test_HasOrders()
        {
            // arrange
            var sut = new User();
            // act

            // assert
            Assert.IsType<List<Order>>(sut.Orders);    
            Assert.NotNull(sut);        
        }

        [Fact]
        private void Test_ChosenStoreExists()
        {
            var sut = new User();
            //idk if this is testing??
            sut.ChosenStore = new Store();
            Assert.IsType<Store>(sut.ChosenStore);    
            Assert.NotNull(sut.ChosenStore);
        }
    }
}