using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05Variations
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 2;
            string[] subSet = new string[] { "hi", "a", "b" };
            int[] variationIndexes = new int[subSet.Length];
            Variate(0, k, subSet.Length, subSet, variationIndexes);
        }

        static void Variate(int i, int k, int n, string[] subSet, int[] varIndexes)
        {
            if (i >= k)
            {
                Print(k, subSet, varIndexes);
                return;
            }

            for (int j = 0; j < n; j++)
            {
                varIndexes[i] = j;
                Variate(i + 1, k, n, subSet, varIndexes);
            }
        }
        
        static void Print(int n, string[] set, int[] varIndexes)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", set[varIndexes[i]]);
            }

            Console.WriteLine();
        }
    }
}