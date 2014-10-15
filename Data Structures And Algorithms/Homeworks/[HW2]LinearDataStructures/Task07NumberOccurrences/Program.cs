using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07NumberOccurrences
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

            var result = CountNumberOccurrences(numbers);

            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }

        private static bool TryToParse(string input)
        {
            int number = 0;
            bool isParsed = Int32.TryParse(input, out number);

            return isParsed;
        }

        private static SortedDictionary<int, int> CountNumberOccurrences(List<int> numbers)
        {
            var occurrences = new SortedDictionary<int, int>();

            foreach (var num in numbers)
            {
                if (occurrences.ContainsKey(num))
                {
                    occurrences[num] += 1;
                }
                else
                {
                    occurrences.Add(num, 1);
                }
            }

            return occurrences;
        }
    }
}
