using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02AcademyTasks
{
    class Program
    {
        static List<int> numbers = new List<int>();
        static int bestTasks;
        static int variety;
        static int maxIndex = -1;

        static void Main(string[] args)
        {
            string pleasantness = Console.ReadLine();
            variety = int.Parse(Console.ReadLine());

            var tokens = pleasantness.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                numbers.Add(int.Parse(token));
            }

            int currentMin = numbers[0];
            int currentMax = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                currentMin = Math.Min(currentMin, numbers[i]);
                currentMax = Math.Max(currentMax, numbers[i]);

                if (currentMax - currentMin >= variety)
                {
                    maxIndex = i;
                    break;
                }
            }

            if (maxIndex == -1)
            {
                Console.WriteLine(numbers.Count);
                return;
            }

            bestTasks = numbers.Count;
            Solve(0, 1, numbers[0], numbers[0]);
            Console.WriteLine(bestTasks);
        }

        static void Solve(int currentIndex, int solvedTasks, int currentMin, int currentMax)
        {
            if (currentMax - currentMin >= variety)
            {
                bestTasks = Math.Min(bestTasks, solvedTasks);
                return;
            }

            if (currentIndex >= maxIndex)
            {
                return;
            }

            for (int i = 2; i >= 1; i--)
            {
                if (currentIndex + i < numbers.Count)
                {
                    Solve(currentIndex + i, solvedTasks + 1,
                        Math.Min(currentMin, numbers[currentIndex + i]),
                        Math.Max(currentMax, numbers[currentIndex + i]));
                }

                if (bestTasks != numbers.Count)
                {
                    return;
                }
            }
        }
    }
}