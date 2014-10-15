﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11AllPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] set = { 1, 3, 5, 5 };
             //int[] set = { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            var unique = new Dictionary<int, int>();

            for (int i = 0; i < set.Length; i++)
            {
                if (unique.ContainsKey(set[i]))
                {
                    unique[set[i]]++;
                }
                else
                {
                    unique[set[i]] = 1;
                }
            }

            int[] keys = unique.Select(x => x.Key).ToArray();
            GetPerm(new int[set.Length], unique, keys, 0);
        }

        private static void GetPerm(int[] comb, Dictionary<int, int> unique, int[] keys, int index)
        {
            if (index == comb.Length)
            {
                Console.WriteLine("{{{0}}}", string.Join(", ", comb));
                return;
            }

            for (int i = 0; i < keys.Length; i++)
            {
                if (unique[keys[i]] > 0)
                {
                    comb[index] = keys[i];
                    unique[keys[i]]--;
                    GetPerm(comb, unique, keys, index + 1);
                    unique[keys[i]]++;
                }
            }
        }
    }
}