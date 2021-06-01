using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDKata1;

namespace UnitTestTDDKata1
{
    [TestClass]
    public class UnitTest1
    {
        private StringCalculator _calculator;

        public UnitTest1()
        {
            _calculator = new StringCalculator();
        }

        [TestMethod]
        public void StringCalculatorEmptyLine()
        {
            string numberString = "";

            Program program = new Program();
            int result = _calculator.Add(numberString);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void StringCalculatorTwoMeanings()
        {
            string numberString = "1,2";

            Program program = new Program();
            int result = _calculator.Add(numberString);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void StringCalculatorUnknownAmountOfNumbers()
        {
            string numberString = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15";

            Program program = new Program();
            int result = _calculator.Add(numberString);
            Assert.AreEqual(result, 120);
        }
    }
}
