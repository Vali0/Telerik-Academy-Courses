using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06RemoveOddOccurrencedNumbers
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

            // Get elements which we want to remove
            var elementsToRemove = numbers.ToLookup(x => x).Where(y => y.Count() % 2 != 0);

            foreach (var num in elementsToRemove)
            {
                // Remove all elements in original array which are odd (founded by elementsToRemove)
                numbers.RemoveAll(x => x == num.Key);
            }

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