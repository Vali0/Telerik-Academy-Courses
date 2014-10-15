namespace Task01CountNumberOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            var occurrences = CountOccurrences(numbers);
            PrintOccurrences(occurrences);
        }

        private static SortedDictionary<double, int> CountOccurrences(double[] numbers)
        {
            var occurrencesDictionary = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!occurrencesDictionary.ContainsKey(num))
                {
                    occurrencesDictionary.Add(num, 0);
                }

                occurrencesDictionary[num]++;
            }

            return occurrencesDictionary;
        }

        private static void PrintOccurrences(SortedDictionary<double, int> numbers)
        {
            foreach (var num in numbers)
            {
                Console.WriteLine(num.Key + " -> " + num.Value);
            }
        }
    }
}