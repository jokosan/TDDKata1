using System;
using Xunit;
using TDDKata1;

namespace TddKata1.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TddKata1_StringCalculator_EmptyLine()
        {
            // Arrange
            Program program = new Program();
            string numberString = "";

            // Act
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void TddKata1_StringCalculator_TwoMeanings()
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
        public void TddKata1_StringCalculator_UnknownAmountOfNumbers()
        {
            // Arrange
            Program program = new Program();
            string numberString = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15";

            // Act
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(120, result);
        }

        [Fact]
        public void TddKata1_StringCalculator_InsteadOfCommas()
        {  // Arrange
            Program program = new Program();
            string numberString = "1\n2,3";

            // Act
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(6, result);

        }
    }
}
