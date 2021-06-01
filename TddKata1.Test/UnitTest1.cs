using System;
using Xunit;
using TDDKata1;

namespace TddKata1.Test
{
    public class UnitTest1
    {
        StringCalculator program = new StringCalculator();

        [Fact]
        public void Add_EmptyLine_returnValue0()
        {
            // Arrange      
            string numberString = "";

            // Act
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_TwoMeanings_returnValue3()
        {
            // Arrange
            string numberString = "1,2";

            // Act
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_UnknownAmountOfNumbers_returnValue120()
        {
            // Arrange
            string numberString = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15";

            // Act
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(120, result);
        }

        [Fact]
        public void Add_InsteadOfCommas_returnValue6()
        {  
            // Arrange
            string numberString = "1\n2,3";

            // Act
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_SupportDifferentDelimiters_returnValu3()
        { 
            // Arrange
            string numberString = "//;\n1;2";

            // Act
            int result = program.Add(numberString);

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
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_AllowMultipleDelimiters_returnValue6()
        {
            // Arrange
            string numberString = "//[***]\n1***2***3";

            // Act
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_DelimitersCanBeOfAnyLength_returnValue6()
        {
            // Arrange
            string numberString = "//[*][%]\n1*2%3";

            // Act
            int result = program.Add(numberString);

            // Assert
            Assert.Equal(6, result);
        }
    }
}
