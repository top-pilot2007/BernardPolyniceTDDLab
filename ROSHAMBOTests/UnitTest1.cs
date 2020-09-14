using System;
using System.Reflection;
using Xunit;

namespace ROSHAMBOTests
{
    public class UnitTest1
    {
        [Fact]
        public void RockBeatsScissorsTests()
        {
            //Arrange
            var service = new Service();
            var rock = "Rock";
            var paper = "Paper";
            var expectedResult= "Rock beats Paper";

            //Act
            var result = service.Play(rock, paper);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
