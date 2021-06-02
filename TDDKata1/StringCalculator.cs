using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata1
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers != "")
            {
                var separators = new char[] { ',', '\n', '/', ';', ' ', '*', '%', '[', ']' };
                string[] subs = numbers.Split(separators);

                var subsInt = new List<int>();

                foreach (var item in subs)
                {
                    if (item != "" && 1000 > Convert.ToInt32(item))
                    {
                        subsInt.Add(Convert.ToInt32(item));
                    }
                }

                Validate(subsInt);
                return subsInt.Sum();
            }
            else
            {
                return 0;
            }

        }

        public void Validate(List<int> listInt)
        {
            if (listInt.Any(x => x < 0))
                throw new StringCalculatorException($"negatives not allowed {string.Join(" ", listInt.Where(x => x < 0))}");
        }
    }
}
