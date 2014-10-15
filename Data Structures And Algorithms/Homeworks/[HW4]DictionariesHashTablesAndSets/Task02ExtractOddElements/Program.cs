namespace Task02ExtractOddElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            var occurrences = CountOccurrences(words);

            var oddOccurrences = ExtractOddOccurrences(occurrences);

            if (oddOccurrences.Count > 0)
            {
                PrintOccurrences(oddOccurrences);
            }
            else
            {
                Console.WriteLine("There is no elements which occurres odd times!");
            }
        }

        private static SortedDictionary<string, int> ExtractOddOccurrences(SortedDictionary<string, int> occurrences)
        {
            var oddOccurrences = new SortedDictionary<string, int>();

            foreach (var word in occurrences)
            {
                if (word.Value % 2 != 0)
                {
                    oddOccurrences.Add(word.Key, word.Value);
                }
            }

            return oddOccurrences;
        }

        private static SortedDictionary<string, int> CountOccurrences(string[] words)
        {
            var occurrencesDictionary = new SortedDictionary<string, int>();

            foreach (var word in words)
            {
                if (!occurrencesDictionary.ContainsKey(word))
                {
                    occurrencesDictionary.Add(word, 0);
                }

                occurrencesDictionary[word]++;
            }

            return occurrencesDictionary;
        }

        private static void PrintOccurrences(SortedDictionary<string, int> words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(word.Key + " -> " + word.Value);
            }
        }
    }
}