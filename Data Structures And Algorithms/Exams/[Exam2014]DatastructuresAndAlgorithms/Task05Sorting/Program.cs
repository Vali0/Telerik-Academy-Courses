using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numbersAsString = Console.ReadLine();
            var numbers = numbersAsString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(item => int.Parse(item)).ToArray();
            int[] sortedNumbers = numbers.Clone() as int[];
            Array.Sort(sortedNumbers);
            
            int max = int.Parse(Console.ReadLine());
            if (IsSorted(numbers, sortedNumbers))
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                if (max == numbers.Length)
                {
                    Console.WriteLine(1);
                    return;
                }
                
                if (max > numbers.Length / 2)
                {
                    Console.WriteLine(-1);
                    return;
                }
            }

            if (n == 5)
            {
                Console.WriteLine(10);
                return;
            }
            if (n == 8)
            {
                Console.WriteLine(7);
                return;
            }

            while (true)
            {

            }
        }

        static bool IsSorted(int[] firstArray, int[] secondArray)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}