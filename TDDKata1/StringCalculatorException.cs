using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata1
{
    public class StringCalculatorException : Exception
    {
        public StringCalculatorException(string message)
            : base(message)
        {
            
        }
    }
}
