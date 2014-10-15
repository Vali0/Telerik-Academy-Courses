using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04HashTableImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new HashTable<string, int>();
            hashTable.Add("Pesho", 20);
            hashTable.Add("Gosho", 22);
            hashTable.Add("Ivan", 2);
            hashTable.Add("Stamat", 71);
            hashTable.Remove("Ivan");

            Console.WriteLine("Is there removed one: " + hashTable.ContainsKey("Ivan"));
            Console.WriteLine("Is there added one: "+hashTable.ContainsKey("Pesho"));
            Console.WriteLine("Hash table keys: "+string.Join(", ", hashTable.Keys));

            Console.WriteLine("Value of the record with key Pesho is: "+hashTable["Pesho"]);
            hashTable["Pesho"] = 99;
            Console.WriteLine("After changing value of the key Pesho: "+ hashTable["Pesho"]);

            Console.WriteLine("Saved elements in table:");
            foreach (var pair in hashTable)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
