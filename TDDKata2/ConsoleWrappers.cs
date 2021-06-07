using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata2
{
    public class ConsoleWrappers 
    {
        private readonly ConsoleVirtual _consoleVirtual;

        public ConsoleWrappers()
        {
            _consoleVirtual = new ConsoleVirtual();
        }

    }
}
