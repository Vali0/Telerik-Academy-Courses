using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[] used = new int[n];
            int[] elements = new int[n];
            Permutate(0, n, elements, used);
        }
        static void Permutate(int i, int n, int[] elements, int[] used)
        {
            if (i >= n)
            {
                Print(n, elements);

                return;
            }

            for (int k = 0; k < n; k++)
            {
                if (used[k] == 0)
                {
                    used[k] = 1;
                    elements[i] = k;
                    Permutate(i + 1, n, elements, used);
                    used[k] = 0;
                }
            }
        }
        static void Print(int n, int[] elements)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", elements[i] + 1);
            }

            Console.WriteLine();
        }
    }
}