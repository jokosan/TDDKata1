using System;
using Xunit;
using TDDKata1;

namespace TddKata1.Test
{
    public class StringCalculatorTests
    {
        private StringCalculator _calculator;

        public StringCalculatorTests()
        {
            _calculator = new StringCalculator();
        }

        [Fact]
        public void Add_EmptyLine_ReturnZero()
        {
            // Arrange      
            string numberString = "";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(0, result);
        }

        //[Fact]
        //public void Add_TwoMeanings_returnValue3()
        //{
        //    // Arrange
        //    string numberString = "1,2";

        //    // Act
        //    int result = calculator.Add(numberString);

        //    // Assert
        //    Assert.Equal(3, result);
        //}

        [Fact]
        public void Add_UnknownAmountOfNumbers_ReturnSumOfAllNumbers()
        {
            // Arrange
            string numberString = "1,2,3,4";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Add_InsteadOfCommas_ReturnSumOfAllNumbers()
        {  
            // Arrange
            string numberString = "1\n2,3";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_SupportDifferentDelimiters_ReturnSumOfAllNumbers()
        { 
            // Arrange
            string numberString = ";\n1;2";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_StringCalculator_ThrowsException()
        {
            // Arrange
            string numberString = "-2";

            // Act
            var exception = Assert.Throws<StringCalculatorException>(() => _calculator.Add(numberString));
            Assert.Equal("negatives not allowed -2", exception.Message);
        }

        [Fact]
        public void Add_NumbersBiggerThan1000Ignored_ReturnSumOfAllNumbers()
        {
            // Arrange
            string numberString = "//j\n1001j2";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_AllowMultipleDelimiters_ReturnSumOfAllNumbers()
        {
            // Arrange
            string numberString = "//[&&&]\n1&&&2&&&3";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_DelimitersCanBeOfAnyLength_ReturnSumOfAllNumbers()
        {
            // Arrange
            string numberString = "//[]][o]\n1]2o3";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(6, result);
        }
    }
}
