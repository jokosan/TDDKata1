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
                Console.WriteLine("you can enter other numbers (enter to exit)?");
            else
                Console.WriteLine("Enter comma separated numbers (enter to exit):");
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
