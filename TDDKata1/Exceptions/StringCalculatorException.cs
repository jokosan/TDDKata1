using System;

namespace TDDKata1.Exceptions
{
    public class StringCalculatorException : Exception
    {
        public StringCalculatorException(string message)
            : base(message)
        {

        }
    }
}
