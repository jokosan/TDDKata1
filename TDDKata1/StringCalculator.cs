using System;
using System.Collections.Generic;
using System.Linq;
using TDDKata1.Exceptions;

namespace TDDKata1
{
    public class StringCalculator
    {
        const int MaxNumberToCalculate = 1000;

        public virtual int Add(string numbers)
        {
            if (IsNullEmptyOrWhitespaceFilled(numbers))
                return 0;

            var delimiters = GetDelimitersFrom(numbers);
            numbers = RemoveDelimiterDataFrom(numbers);

            var subs
               = numbers
                   .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => Convert.ToInt32(x) <= MaxNumberToCalculate)
                        .Select(x => Convert.ToInt32(x));

            Validate(subs);
            return subs.Sum();
        }

        private bool IsNullEmptyOrWhitespaceFilled(string numbers)
            => string.IsNullOrEmpty(numbers) || string.IsNullOrWhiteSpace(numbers);        

        private void Validate(IEnumerable<int> listInt)
        {
            if (listInt.Any(x => x < 0))
                throw new StringCalculatorException($"negatives not allowed {string.Join(" ", listInt.Where(x => x < 0))}");
        }

        private string[] GetDelimitersFrom(string numbers)
        {
            if (!numbers.StartsWith("//"))
                return new string[] { ",", "\n", "/", ";", " ", "*", "%", "[", "]" };

            const string delimiterOpeningBracket = "[";
            const string delimiterEndBracket = "[";
            const int delimiterDataStartPosition = 2;

            int delimiterDataLength
                = numbers.IndexOf("\n") - delimiterDataStartPosition;

            var delimiterData = numbers.Substring(delimiterDataStartPosition, delimiterDataLength);

            if (delimiterData.Contains(delimiterOpeningBracket) ||
               delimiterData.Contains(delimiterEndBracket))
            {
                const string delimiterListSeperator = "][";
                const int delimiterListStartPosition = 1;
                const int delimiterListEndAdjustment = 2;

                delimiterData = delimiterData
                    .Substring(delimiterListStartPosition, delimiterData.Length - delimiterListEndAdjustment);

                return delimiterData
                        .Split(new string[] { delimiterListSeperator }, StringSplitOptions.RemoveEmptyEntries);

            }

            const int defaultDelimiterLength = 1;
            var delimiterString = numbers.Substring(delimiterDataStartPosition, defaultDelimiterLength);

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
