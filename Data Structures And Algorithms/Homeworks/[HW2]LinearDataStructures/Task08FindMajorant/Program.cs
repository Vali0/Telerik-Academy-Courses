using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08FindMajorant
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>()
            {
                2, 2, 3, 3, 2, 3, 4, 3, 3
            };

            var len = numbers.Count / 2 + 1;
            // One row solution.
            // Other way is to make dictionary and to find number with those occurrences that are more or equal to len if exists
            // Look bellow for second solution
            var majorant = numbers.ToLookup(x => x).Where(y => y.Count() >= len);

            if (majorant.Count() > 0)
            {
                Console.WriteLine("Majorant number: " + majorant.First().Key); // There is only one or none majorant members in given array so we can use First()
            }
            else
            {
                Console.WriteLine("There is no majorant member in given array!");
            }

            // Second solution
            var occurrences = CountNumberOccurrences(numbers);
            int majorantNumber = 0;
            if (TryFindMajorant(occurrences, len, out majorantNumber))
            {
                Console.WriteLine("Majorant number: " + majorantNumber);
            }
            else
            {
                Console.WriteLine("There is no majorant member in given array!");
            }
        }

        private static Dictionary<int, int> CountNumberOccurrences(List<int> numbers)
        {
            var occurrences = new Dictionary<int, int>();

            foreach (var num in numbers)
            {
                if (occurrences.ContainsKey(num))
                {
                    occurrences[num] += 1;
                }
                else
                {
                    occurrences.Add(num, 1);
                }
            }

            return occurrences;
        }

        private static bool TryFindMajorant(Dictionary<int, int> occurrences, int neededOccurrences, out int majorant)
        {
            majorant = 0;

            foreach (var item in occurrences)
            {
                if (item.Value >= neededOccurrences)
                {
                    majorant = item.Key;
                    return true;
                }
            }

            return false;
        }
    }
}