using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata1
{
    public class Program
    {

        static void Main(string[] args)
        {
            var user = new UserInterface();
            var stringCalculator = new StringCalculator();
            bool status = false;

            user.StartInfo(status);

            var keyInfo = user.ConfirmActions();

            if (keyInfo)
            {
                do
                {
                    status = true;
                    string UserString = user.UserValueInput();
                    user.ResultValue(stringCalculator.Add(UserString));
                    user.StartInfo(status);
                    keyInfo = user.ConfirmActions();

                    if (keyInfo)
                    {
                        Console.WriteLine("User numbers");
                    }

                } while (keyInfo);
            }
        }

    }
}
