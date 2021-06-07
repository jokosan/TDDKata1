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
            var user = new UserInteraction();
            var stringCalculator = new StringCalculator();

           // bool status = false;

            user.StartInfo(ClassConstant.MessageStart);

            var keyInfo = user.ConfirmActions();

            if (keyInfo)
            {
                do
                {
                    string UserString = user.UserValueInput();
                    user.ResultValue(stringCalculator.Add(UserString));
                    user.StartInfo(ClassConstant.MessageChoiceOfAction);
                    keyInfo = user.ConfirmActions();

                } while (keyInfo);
            }
        }
    }
}
