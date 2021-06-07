using System;
using System.Collections.Generic;
using System.Linq;

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
                   .Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            return ValidateInt(subs, delimiters);
        }

        public int ValidateInt(string[] number, string[] delimiters)
        {
            var listIntResult = new List<int>();
            int result;
            string resultDelimiters = null;

            foreach (var itemChar in delimiters)
                resultDelimiters += itemChar;

            char[] charDelimiters = resultDelimiters.ToCharArray();

            foreach (var item in number)
            {
                if (Int32.TryParse(item, out result) == false)
                {
                    var StringSplit = item.Split(charDelimiters, StringSplitOptions.RemoveEmptyEntries)
                        .Where(x => Convert.ToInt32(x) <= MaxNumberToCalculate)
                        .Select(x => Convert.ToInt32(x));

                    listIntResult.Add(StringSplit.Sum());
                }
                else
                {
                    if (result <= MaxNumberToCalculate)
                        listIntResult.Add(result);
                }
            }

            Validate(listIntResult);
            return listIntResult.Sum();
        }

        private void Validate(IEnumerable<int> listInt)
        {
            var negativeNumbers
               = listInt
                  .Where(number => number < 0)
                  .Select(number => number);

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
