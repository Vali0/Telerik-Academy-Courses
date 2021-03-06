﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06SubSetOfStrings
{
    class Program
    {
        static void GenerateSubset<T>(IList<T> elements, IList<T> variation, int currentIndex = 0, int startIndex = 0)
        {
            if (currentIndex == variation.Count)
            {
                Print(variation);
            }
            else
            {
                for (int i = startIndex; i < elements.Count; i++)
                {
                    variation[currentIndex] = elements[i];
                    GenerateSubset(elements, variation, currentIndex + 1, i + 1);
                }
            }
        }

        static void Print<T>(IList<T> collection)
        {
            Console.WriteLine(string.Join(", ", collection));
        }

        static void Main()
        {
            var elements = new string[] { "heavy", "metal", "universe", };
            int k = 2;
            GenerateSubset(elements, new string[k]);
        }
    }
}