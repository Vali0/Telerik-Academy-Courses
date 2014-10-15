namespace Task03CountWordsInText
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            string text = ReadTextFile();

            var words = SplitToWords(text);

            var occurrences = CountOccurrences(words);

            var sortedByValue = from occur
                                in occurrences
                                orderby occur.Value
                                select occur;

            PrintOccurrences(sortedByValue);
        }

        private static string ReadTextFile()
        {
            string text = "";

            StreamReader reader = new StreamReader("text.txt");
            text = reader.ReadToEnd();
            reader.Close();

            return text;
        }

        private static string[] SplitToWords(string text)
        {
            string[] words = text.Split(new char[] { ' ', ',', '-', '!', '?', '.', '\'', '\"', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            return words;
        }

        private static SortedDictionary<string, int> CountOccurrences(string[] words)
        {
            var occurrencesDictionary = new SortedDictionary<string, int>();

            foreach (var word in words)
            {
                string token = word.ToLower();
                if (!occurrencesDictionary.ContainsKey(token))
                {
                    occurrencesDictionary.Add(token, 0);
                }

                occurrencesDictionary[token]++;
            }

            return occurrencesDictionary;
        }

        private static void PrintOccurrences(IOrderedEnumerable<KeyValuePair<string, int>> words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(word.Key + " -> " + word.Value);
            }
        }
    }
}