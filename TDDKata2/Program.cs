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
            var consoleVirtual = new ConsoleVirtual();
            var stringCalculator = new StringCalculator();

            consoleVirtual.ConsoleWriteLine(ClassConstant.MessageStart);

            var keyInfo = ConfirmActions();

            if (keyInfo)
            {
                do
                {
                    string UserString = consoleVirtual.ConsoleReadLine();
                    int resultSum = (stringCalculator.Add(UserString));
                    consoleVirtual.ConsoleWriteLine($"{ClassConstant.MessageResult} {resultSum}");
                    consoleVirtual.ConsoleWriteLine(ClassConstant.MessageChoiceOfAction);
                    keyInfo = ConfirmActions();

                    if (keyInfo)
                    {
                        Console.WriteLine("User numbers");
                    }

                } while (keyInfo);
            }
        }

        public static bool ConfirmActions()
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                return true;
            else
                return false;
        }
    }
}
