using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests
{
    public class SubsciberTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var Subscriber = new Subscriber();
            Subscriber.Name = "Paul";

            //Act
            var result = Subscriber.Name;

            //Assert
            Assert.Equal("Paul", result);
        }
    }
}