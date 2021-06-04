using System;
using Xunit;
using TDDKata1;
using Moq;
using System.Threading;
using System.IO;
using TDDKata1.Wrapper;

namespace TddKata1.Tests
{
    public class StartCalculatorTests
    {
     
        private Mock<IUserInterface> startCalculatorMock = new Mock<IUserInterface>();

        [Fact]
        public void StartInfo_InvitationsToStartWork_valueFalse()
        {
            // Arrange   
            bool workStatus = false;
            ConsoleWrappers consoleWrappers = new ConsoleWrappers(startCalculatorMock.Object);

            // Act
            startCalculatorMock.Setup(p => p.StartInfo(workStatus)).Verifiable();
            consoleWrappers.StartInfo(workStatus);

            // Assert
            startCalculatorMock.Verify(w => w.StartInfo(It.Is<bool>(s => s == false)), Times.Once);
        }

        [Fact]
        public void ConfirmActions_Keystrokes_KeyEnterReturnTrue()
        {
            // Arrange   
            bool keyEnter = true;
            ConsoleWrappers consoleWrappers = new ConsoleWrappers(startCalculatorMock.Object);

            // Act
            startCalculatorMock.Setup(p => p.ConfirmActions()).Returns(keyEnter);
            var result = consoleWrappers.ConfirmActions();

            // Assert
            Assert.Equal(keyEnter, result);
        }

        [Fact]
        public void StartInfo_ContinueWork_ValueTrue()
        {
            // Arrange   
            bool workStatus = true;
            ConsoleWrappers consoleWrappers = new ConsoleWrappers(startCalculatorMock.Object);

            // Act
            startCalculatorMock.Setup(p => p.StartInfo(workStatus)).Verifiable();
            consoleWrappers.StartInfo(workStatus);

            // Assert
            startCalculatorMock.Verify(w => w.StartInfo(It.Is<bool>(s => s == workStatus)), Times.Once);
        }

        [Fact]
        public void UserValurInput_CustomValueOutput_ReturnUserString()
        {
            // Arrange   
            string customValueOutput = "2,5";
            ConsoleWrappers consoleWrappers = new ConsoleWrappers(startCalculatorMock.Object);

            // Act
            startCalculatorMock.Setup(p => p.UserValueInput()).Returns(customValueOutput);
            var resultString = consoleWrappers.UserValueInput();

            // Assert
            Assert.Equal(customValueOutput, resultString);
        }

        [Fact]
        public void Add_SumOfCustomValue_ReturnSumOfAllNumbers()
        {
            // Arrange   
            string userValue = "2,5";
            int expectedValue = 7;
            StringCalculator stringCalculator = new StringCalculator();

            // Act
            var resultSum = stringCalculator.Add(userValue);

            // Assert
            Assert.Equal(expectedValue, resultSum);       
        }

        [Fact]
        public void ResultValue_ResultSumOfCustomValue_SumOfValues()
        {
            // Arrange   
            int resultSumUser = 7;
            ConsoleWrappers consoleWrappers = new ConsoleWrappers(startCalculatorMock.Object);

            // Act
            startCalculatorMock.Setup(p => p.ResultValue(resultSumUser)).Verifiable();
            consoleWrappers.ResultValue(resultSumUser);

            // Assert
            startCalculatorMock.Verify(w => w.ResultValue(It.Is<int>(s => s == resultSumUser)), Times.Once);
        }


        [Fact]
        public void ConfirmActions_Keystrokes_KeyEnterReturnFalse()
        {
            // Arrange   
            bool keyEsc = false;
            ConsoleWrappers consoleWrappers = new ConsoleWrappers(startCalculatorMock.Object);

            // Act
            startCalculatorMock.Setup(p => p.ConfirmActions()).Returns(keyEsc);
            var result = consoleWrappers.ConfirmActions();

            // Assert
            Assert.Equal(keyEsc, result);
        }
    }
}
