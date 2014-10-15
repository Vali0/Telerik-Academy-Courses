using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01CalculateSumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            IList<int> numbers = new List<int>();
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

            Console.WriteLine("Numbers are: " + string.Join(", ", numbers));
            Console.WriteLine("Sum of numbers is: " + CalculateSum(numbers));
            Console.WriteLine("Average of numbers is: " + CalculateAverage(numbers));
        }
        
        private static bool TryToParse(string input)
        {
            int number = 0;
            bool isParsed = Int32.TryParse(input, out number);

            return isParsed;
        }

        private static int CalculateSum(IList<int> numbers)
        {
            int result = 0;

            foreach (var num in numbers)
            {
                result += num;
            }

            return result;
        }

        private static double CalculateAverage(IList<int> numbers)
        {
            double result = 0;
            int sumOfNumbers = 0;
            int numberOfElements = 0;

            sumOfNumbers = CalculateSum(numbers);
            numberOfElements = numbers.Count;

            result = (sumOfNumbers / (numberOfElements * 1.0));

            return result;
        }
    }
}