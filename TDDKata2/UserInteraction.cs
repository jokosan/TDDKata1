using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDKata2.Constants;
using TDDKata2.Contract;

namespace TDDKata2
{
    public class UserInteraction : IUserInteraction
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }

        public string UserValueInput()
            => Console.ReadLine();

    }
}
