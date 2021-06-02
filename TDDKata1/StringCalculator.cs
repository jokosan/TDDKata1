using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata1
{
    public class StringCalculator
    {
        const int MaxNumberToCalculate = 1000;

        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers) || string.IsNullOrWhiteSpace(numbers))
                return 0;

            var delimiters = GetDelimitersFrom(numbers);
            numbers = RemoveDelimiterDataFrom(numbers);

            var subs
               = numbers
                   .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                   .Where(stringNumber => Convert.ToInt32(stringNumber) <= MaxNumberToCalculate)
                   .Select(stringNumber => Convert.ToInt32(stringNumber));

            Validate(subs);
            return subs.Sum();
        }

        private void Validate(IEnumerable<int> listInt)
        {
            var negativeNumbers
               = listInt
                  .Where(number => number < 0)
                  .Select(number => number)
                  .ToList();

            if (negativeNumbers.Any(x => x < 0))
                throw new StringCalculatorException($"negatives not allowed {string.Join(" ", listInt.Where(x => x < 0))}");
        }

        private string[] GetDelimitersFrom(string numbers)
        {
            if (!numbers.StartsWith("//"))
                return new string[] { ",", "\n", "/", ";", " ", "*", "%", "[", "]" };

            const string DelimiterOpeningBracket = "[";
            const string DelimiterEndBracket = "[";
            const int DelimiterDataStartPosition = 2;

            int delimiterDataLength
                = numbers.IndexOf("\n") - DelimiterDataStartPosition;

            var delimiterData = numbers.Substring(DelimiterDataStartPosition, delimiterDataLength);

            if (delimiterData.Contains(DelimiterOpeningBracket) ||
               delimiterData.Contains(DelimiterEndBracket))
            {
                const string DelimiterListSeperator = "][";
                const int DelimiterListStartPosition = 1;
                const int DelimiterListEndAdjustment = 2;

                delimiterData = delimiterData
                    .Substring(DelimiterListStartPosition, delimiterData.Length - DelimiterListEndAdjustment);

                return delimiterData
                        .Split(new string[] { DelimiterListSeperator }, StringSplitOptions.RemoveEmptyEntries);
            }

            const int DefaultDelimiterLength = 1;
            var delimiterString = numbers.Substring(DelimiterDataStartPosition, DefaultDelimiterLength);

            return new string[] { delimiterString };
        }

        private string RemoveDelimiterDataFrom(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                int start = numbers.IndexOf("\n") + 1;
                return numbers.Substring(start);
            }

            return numbers;
        }
    }
}
