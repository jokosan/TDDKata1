using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata1
{
    public class UserInterface : IUserInterface
    {       
        public void StartInfo(bool status)
        {
            if (status)
                Console.WriteLine("you can enter other numbers (enter to exit)?");
            else
                Console.WriteLine("Enter comma separated numbers (enter to exit):");
        }

        public bool ConfirmActions()
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                return true;
            else
                return false;
        }

        public string UserValueInput()
            => Console.ReadLine();

        public void ResultValue(int value)
        {
            Console.WriteLine($"Result is: {value}");
        }
    }
}
