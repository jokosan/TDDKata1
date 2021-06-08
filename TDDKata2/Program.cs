using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDKata1;

namespace TDDKata2
{
    class Program
    {
        static void Main(string[] args)
        {
            new UserConsole(new StringCalculator(), new UserInteraction()).Start();
        }
    }
}