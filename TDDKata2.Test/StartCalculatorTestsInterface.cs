using Moq;
using TDDKata1;
using TDDKata2.Constants;
using TDDKata2.Contract;
using Xunit;

namespace TDDKata2.Test
{
    public class StartCalculatorTestsInterface
    {
        private UserConsole _userConsole;

        [Fact]
        public void Start_StartMessage_Message()
        {
            // Arrange
            Mock<StringCalculator> stringCalculatorMock = new Mock<StringCalculator>();
            Mock<IUserInteraction> startCalculatorMock = new Mock<IUserInteraction>();


            startCalculatorMock.Setup(x => x.UserValueInput())
                    .Returns("");

            stringCalculatorMock.Setup(x => x.Add(""))
                .Returns(0);

            _userConsole = new UserConsole(stringCalculatorMock.Object, startCalculatorMock.Object);

            // Act
            _userConsole.Start();

            // Asert
            startCalculatorMock.Verify(x => x.Info(MessageUsers.MessageStart));
        }

        [Fact]
        public void Start_EnteringValuesTwice_ReturnValuesTwice()
        {
            // Arrange

            Mock<StringCalculator> stringCalculatorMock = new Mock<StringCalculator>();
            Mock<IUserInteraction> startCalculatorMock = new Mock<IUserInteraction>();

            startCalculatorMock.SetupSequence(x => x.UserValueInput())
                .Returns("7,8")
                .Returns("8,9")
                .Returns("");

            stringCalculatorMock.SetupSequence(x => x.Add(It.IsAny<string>())).Returns(15).Returns(17);

            _userConsole = new UserConsole(stringCalculatorMock.Object, startCalculatorMock.Object);

            // Act
            _userConsole.Start();

            // Asert
            startCalculatorMock.Verify(x => x.Info(MessageUsers.MessageChoiceOfAction), Times.Exactly(2));
        }

        [Fact]
        public void Start_EnteringValuesTwice_GetTheSumOfValuesTwice()
        {
            // Arrange

            Mock<StringCalculator> stringCalculatorMock = new Mock<StringCalculator>();
            Mock<IUserInteraction> startCalculatorMock = new Mock<IUserInteraction>();

            var firstValue = "7,8";
            var secondValue = "8,9";

            var resulFirsttValue = 15;
            var resultSecondValue = 17;

            startCalculatorMock.SetupSequence(x => x.UserValueInput())
               .Returns(firstValue)
               .Returns(secondValue)
               .Returns("");

            stringCalculatorMock.Setup(x => x.Add(firstValue))
                .Returns(resulFirsttValue);

            stringCalculatorMock.Setup(x => x.Add(secondValue))
                .Returns(resultSecondValue);

            _userConsole = new UserConsole(stringCalculatorMock.Object, startCalculatorMock.Object);

            // Act
            _userConsole.Start();

            // Asert
            startCalculatorMock.Verify(x => x.Info($"{MessageUsers.MessageResult} {resulFirsttValue}"));
            startCalculatorMock.Verify(x => x.Info($"{MessageUsers.MessageResult} {resultSecondValue}"));
        }

    }
}

