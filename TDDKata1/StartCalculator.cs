using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata1
{
    public class StartCalculator
    {
        public virtual void Start()
        {
            bool status = false;

            var stringCalculator = new StringCalculator();
            StartInfo(status);

            var keyInfo = ConfirmActions();

            if (keyInfo)
            {
                do
                {
                    status = true;
                    string UserString = UserValueInput();
                    ResultValue(stringCalculator.Add(UserString));
                    StartInfo(status);
                    keyInfo = ConfirmActions();

                    if (keyInfo)
                    {
                        Console.WriteLine("User numbers");
                    }

                } while (keyInfo);
            }
        }

        public void StartInfo(bool status)
        {
            if (status)
                Console.WriteLine("you can enter other numbers (enter to exit)?");
            else
                Console.WriteLine("Enter comma separated numbers (enter to exit):");
        }

        public  bool ConfirmActions()
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                return true;
            else
                return false;
        }

        public virtual string UserValueInput()
            => Console.ReadLine();

        public virtual void ResultValue(int value)
        {
            Console.WriteLine($"Result is: {value}");
        }
    }
}
