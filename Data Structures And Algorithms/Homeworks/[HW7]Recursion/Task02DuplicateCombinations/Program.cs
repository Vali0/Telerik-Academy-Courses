﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02DuplicateCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            CombinationsGenerator generator = new CombinationsGenerator(3);
            var result = generator.GetAllCombinations(2);

            foreach (var vector in result)
            {
                foreach (var num in vector)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
            }
        }
    }
}