using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata2
{
    public class ConsoleVirtual
    {
        public virtual void ConsoleWriteLine(string name)
        {
            Console.WriteLine(name);
        }

        public virtual string ConsoleReadLine()
            => Console.ReadLine();
    }
}
