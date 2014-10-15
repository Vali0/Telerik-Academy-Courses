using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03SortNumbersInIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            List<int> numbers = new List<int>();
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

            numbers.Sort();
            
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static bool TryToParse(string input)
        {
            int number = 0;
            bool isParsed = Int32.TryParse(input, out number);

            return isParsed;
        }
    }
}