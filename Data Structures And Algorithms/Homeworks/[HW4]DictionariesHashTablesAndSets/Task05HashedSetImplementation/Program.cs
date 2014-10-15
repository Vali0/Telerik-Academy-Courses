namespace Task05HashedSetImplementation
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
            HashedSet<string> firstSet = new HashedSet<string>();
            HashedSet<string> secondSet = new HashedSet<string>();

            firstSet.Add("Pesho");
            firstSet.Add("Pesho");
            firstSet.Add("Kiro");
            firstSet.Add("Pesho");
            firstSet.Add("Ivan");
            firstSet.Add("Zumba");

            secondSet.Add("Pesho");
            secondSet.Add("Kiro");
            secondSet.Add("Mariika");
            secondSet.Add("Zorbas");

            Console.WriteLine("Number of saved elements: " + firstSet.Count);
            Console.WriteLine("Is there Pesho: " + firstSet.Contains("Pesho"));

            Console.WriteLine("All sets: ");

            firstSet.Remove("Ivan");
            foreach (var set in firstSet)
            {
                Console.WriteLine(set);
            }

            firstSet.UnionWith(secondSet);
            Console.WriteLine("Ater union first set is: ");
            foreach (var set in firstSet)
            {
                Console.WriteLine(set);
            }

            firstSet.IntersectWith(secondSet);
            Console.WriteLine("After intesection first set is: ");
            foreach (var set in firstSet)
            {
                Console.WriteLine(set);
            }
        }
    }
}
