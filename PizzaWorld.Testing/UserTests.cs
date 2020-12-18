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
    }
}