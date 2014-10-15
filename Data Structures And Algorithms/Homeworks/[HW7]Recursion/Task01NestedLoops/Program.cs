using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int nestingLevel = 0;
            int[] elements = new int[n];

            Loop(elements, n, nestingLevel);
        }

        public static void Loop(int[] elements, int iterations, int nestingLevel)
        {
            if (nestingLevel == iterations)
            {
                PrintNestedLoop(elements);
                return;
            }

            for (int i = 0; i < iterations; i++)
            {
                elements[nestingLevel] = i + 1;
                Loop(elements, iterations, nestingLevel + 1);
            }
        }

        public static void PrintNestedLoop(int[] elements)
        {
            Console.WriteLine(string.Join(", ", elements));
        }
    }
}