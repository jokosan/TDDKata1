using System;
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
