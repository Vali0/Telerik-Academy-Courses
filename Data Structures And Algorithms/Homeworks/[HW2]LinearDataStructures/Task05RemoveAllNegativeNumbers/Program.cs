using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05RemoveAllNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            List<float> numbers = new List<float>();
            Console.WriteLine("Enter single number on different line (empty line or whitespace to end)");

            do
            {
                line = Console.ReadLine();
                bool canParse = TryToParse(line);

                if (canParse)
                {
                    numbers.Add(int.Parse(line));
                }
            }
            while (!String.IsNullOrWhiteSpace(line));

            var positiveNumbers = RemoveAllNegativeNumbers(numbers);
            Console.WriteLine(string.Join(", ", positiveNumbers));
        }

        private static List<float> RemoveAllNegativeNumbers(List<float> numbers)
        {
            List<float> positiveNumbers = new List<float>();
            foreach (var num in numbers)
            {
                if (num >= 0)
                {
                    positiveNumbers.Add(num);
                }
            }

            return positiveNumbers;
        }

        private static bool TryToParse(string input)
        {
            float number = 0;
            bool isParsed =  float.TryParse(input, out number);

            return isParsed;
        }
    }
}