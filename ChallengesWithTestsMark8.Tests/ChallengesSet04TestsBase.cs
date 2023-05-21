using System;
using Xunit;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet04TestsBase
    {

        [Fact]
        public void NegativeFactorialShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            ChallengesSet04 challenger = new ChallengesSet04();
            int negative1 = -1;
            int negative2 = -2;
            int negative3 = -3;

            // Act
            Action actual1 = () => challenger.Factorial(negative1);
            Action actual2 = () => challenger.Factorial(negative2);
            Action actual3 = () => challenger.Factorial(negative3);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(actual1);
            Assert.Throws<ArgumentOutOfRangeException>(actual2);
            Assert.Throws<ArgumentOutOfRangeException>(actual3);
        }
    }
}