using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
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

        [Fact]
        private void Test_HasOrders()
        {
            var store = new Store();
            Assert.IsType<List<Order>>(store.Orders);
        }

        [Fact]
        private void Test_HasPizzas()
        {
            var store = new Store();
            Assert.IsType<List<APizzaModel>>(store.Pizzas);
        }

        [Fact]
        private void Test_CreatesOrder()
        {
            var store = new Store();
            store.CreateOrder();
            Assert.NotNull(store.Orders);
        }
    }
}