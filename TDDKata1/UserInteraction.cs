using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDKata1.Contract;

namespace TDDKata1
{
    public class UserInteraction : IUserInteraction
    {       
        public void StartInfo(bool status)
        {           
            if (status)
                Console.WriteLine(ClassConstant.MessageChoiceOfAction);
            else
                Console.WriteLine(ClassConstant.MessageStart);
        }

        public void StartInfo(string message)
        {
            Console.WriteLine(message);
        }

        public bool ConfirmActions()
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                return false;
            else
                return true;
        }

        public string UserValueInput()
            => Console.ReadLine();

        public void ResultValue(int value)
        {
            Console.WriteLine($"{ClassConstant.MessageResult} {value}");
        }
    }
}
