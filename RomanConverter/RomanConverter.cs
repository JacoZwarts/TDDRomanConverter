using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanConverter
{
    public class RomanConverter
    {
        public RomanConverter()
        {
            romanSymbols.Add('I', 1);
            romanSymbols.Add('V', 5);
            romanSymbols.Add('X', 10);
            romanSymbols.Add('L', 50);
            romanSymbols.Add('C', 100);
            romanSymbols.Add('D', 500);
            romanSymbols.Add('M', 1000);
        }

        private IDictionary<char, int> romanSymbols = new Dictionary<char, int>();

        public int ConvertConvertRomanToNumericNumber(string roman)
        {
            roman = roman.ToUpper();
            int sum = 0;
            int current = 0;
            int previous = 0;

            for (int i = 0; i < roman.ToCharArray().Length; i++)
            {
                if (romanSymbols.ContainsKey(roman[i]))
                {
                    current = romanSymbols.First(c => c.Key == roman[i]).Value;
                    previous = i == 0 ? 0 : romanSymbols.First(c => c.Key == roman[i - 1]).Value;
                    if (previous >= current)
                        sum += current;
                    else
                    {
                        sum -= previous;
                        sum += (current - previous);
                    }
                }

                else
                    throw new Exception("Invalid roman character");
            }

            return sum;
        }
    }
}