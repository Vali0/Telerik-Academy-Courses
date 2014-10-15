using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gma.DataStructures.StringSearch;
using System.IO;

namespace Task03TreiImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LargeFileGenerator.GenerateBigFile();
            ShowWordsOccurrence();
        }

        private static void ShowWordsOccurrence()
        {
            var trie = new Trie<string>();
            var reader = new StreamReader("text.txt");
            var text = "";
            var elements = new HashSet<string>();

            using (reader)
            {
                text = reader.ReadToEnd();
            }

            var tokens = text.Split(new char[] { ' ', '.', ',', '!', '?', '-', ':', '\n', '\r', '\'', '\"' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                elements.Add(token);
                trie.Add(token, token);
            }

            foreach (var element in elements)
            {
                var elementsCount = trie.Retrieve(element).Count();
                Console.WriteLine("{0} contains {1} times.", element, elementsCount);
            }
        }
    }
}