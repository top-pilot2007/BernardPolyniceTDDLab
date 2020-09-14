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
            var scissors = "Scissors";
            var expectedResult= "Rock beats Scissors";

            //Act
            var result = service.Play(rock, scissors);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void PaperBeatsRockTests()
        {
            //Arrange
            var service = new Service();
            var paper = "Paper";
            var rock = "Rock";
            var expectedResult = "Paper beats Rock";

            //Act
            var result = service.Play(paper, rock);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
