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
        public void Add_EmptyLine_returnValue0()
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
        public void Add_UnknownAmountOfNumbers_returnValue10()
        {
            // Arrange
            string numberString = "1,2,3,4";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Add_InsteadOfCommas_returnValue6()
        {  
            // Arrange
            string numberString = "1\n2,3";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_SupportDifferentDelimiters_returnValu3()
        { 
            // Arrange
            string numberString = "//;\n1;2";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(3, result);
        }

        //[Fact]
        //public void TddKata1_StringCalculator_negativeNumberThrowsAnException()
        //{
        //    // Arrange
        //    Program program = new Program();
        //    string numberString = "1,-2";

        //    // Act
        //    int result = program.Add(numberString);

        //    // Assert
        //    Assert.Equal(3, result);
        //}

        [Fact]
        public void Add_NumbersBiggerThan1000Ignored_returnValue2()
        {
            // Arrange
            string numberString = "1001, 2";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_AllowMultipleDelimiters_returnValue6()
        {
            // Arrange
            string numberString = "//[***]\n1***2***3";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_DelimitersCanBeOfAnyLength_returnValue6()
        {
            // Arrange
            string numberString = "//[*][%]\n1*2%3";

            // Act
            int result = _calculator.Add(numberString);

            // Assert
            Assert.Equal(6, result);
        }
    }
}
