using System;

namespace TDDKata1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stringCalculator = new StringCalculator();
            stringCalculator.Add(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
