using System;
using Xunit;
using TDDKata1;

namespace TddKata1.Test
{
    public class UnitTest1
    {
        [Fact]
        public void StringCalculatorEmptyLine()
        {
            // Arrange
            Program program = new Program();
            string numberString = "";

            // Act
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(0, result) ;
        }

        [Fact]
        public void StringCalculatorTwoMeanings()
        {
            // Arrange
            Program program = new Program();
            string numberString = "1,2";

            // Act
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void StringCalculatorUnknownAmountOfNumbers()
        {
            // Arrange
            Program program = new Program();
            string numberString = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15";

            // Act
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(120, result);
        }
    }
}
