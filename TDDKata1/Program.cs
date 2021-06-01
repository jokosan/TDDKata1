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
            var stringCalculator = new StringCalculator();
            Console.WriteLine(stringCalculator.Add(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
