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
            var program = new Program();
            Console.WriteLine(program.Add(Console.ReadLine()));
            Console.ReadLine();
        }

        //public string[]

        public int Add(string numbers)
        {
            if (numbers != "")
            {
                var separators = new char[] { ',', '\n', '/', ';', ' ', '*', '%', '[', ']' };
                string[] subs = numbers.Split(separators);               
                var subsInt = new List<int>();

                foreach (var item in subs)
                {
                    if (item != "" &&  1000 > Convert.ToInt32(item))
                        subsInt.Add(Convert.ToInt32(item));
                }

                return subsInt.Sum();
            }
            else
            {
                return 0;
            }
        }
    }
}
