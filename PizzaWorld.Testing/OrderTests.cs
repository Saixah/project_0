using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
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

        [Fact]
        private void Test_CheesePizza()
        {
            // arrange
            var sut = new Order();
            // act
            // assert
            sut.MakeCheesePizza();
            sut.MakeCheesePizza();

            foreach(APizzaModel pizza in sut.Pizzas)
                Assert.IsType<CheesePizza>(pizza);            
        }

        [Fact]
        private void Test_MeatPizza()
        {
            // arrange
            var sut = new Order();
            // act
            // assert
            sut.MakeMeatPizza();
            sut.MakeMeatPizza();

            foreach(APizzaModel pizza in sut.Pizzas)
                Assert.IsType<MeatPizza>(pizza);            
        }

        [Fact]
        private void Test_CustomPizza()
        {
            // arrange
            var sut = new Order();
            // act
            // assert
            sut.MakeCustomPizza(new Crust(), new Size(), new List<Topping>());
            sut.MakeCustomPizza(new Crust(), new Size(), new List<Topping>());

            foreach(APizzaModel pizza in sut.Pizzas)
                Assert.IsType<CustomPizza>(pizza);            
        }
    }
}