using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03BiDictionaryImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var bidictionary = new BiDictionary<string, int, string>(true);
            bidictionary.Add("Pesho", 999, "Trubata");
            bidictionary.Add("Kiro", -123, "Motikata");
            bidictionary.Add("Stamat", 3, "Ismailov");
            bidictionary.Add("Pesho", 5, "Trubata");
            bidictionary.Add("Stamat", 2, "Zorbas");

            Console.WriteLine(string.Join(" ", bidictionary.GetByFirstKey("Pesho")));
            Console.WriteLine(string.Join(" ", bidictionary.GetBySecondKey(-123)));
            Console.WriteLine(string.Join(" ", bidictionary.GetByFirstAndSecondKey("Pesho", 5)));

            Console.WriteLine(bidictionary.Count);
            bidictionary.RemoveByFirstKey("Pesho");
            Console.WriteLine(bidictionary.Count);
            
            bidictionary.RemoveBySecondKey(13289449);
            Console.WriteLine(bidictionary.Count);
            
            bidictionary.RemoveByFirstAndSecondKey("Stamat", 3);
            Console.WriteLine(bidictionary.Count);
        }
    }
}
