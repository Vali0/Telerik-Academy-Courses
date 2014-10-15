using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

class Task05TwoIsBetterThanOne
{
    static void Main(string[] args)
    {
        //Stopwatch sw = new Stopwatch();

        string AB = Console.ReadLine();


        //sw.Start();

        string[] ar = AB.Split(' ');
        long counter = LuckyNumber(Convert.ToInt64(ar[0]), Convert.ToInt64(ar[1]));

        string listOfNumbers = Console.ReadLine();
        int percent = int.Parse(Console.ReadLine());

        string[] list = listOfNumbers.Split(',');
        int[] numbers = new int[list.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(list[i]);
        }
        Array.Sort(numbers);
        double index = 0;
        index = (numbers.Length * percent) / (double)100;
        index = Math.Round(index) - 1;

        Console.WriteLine(counter);
        Console.WriteLine(numbers[(int)index]);
        //Console.WriteLine(sw.Elapsed);
        //Console.WriteLine(sw.ElapsedMilliseconds);
    }

    static long LuckyNumber(long a, long b)
    {
        int counter = 0;
        for (long i = a; i <= b; i++)
        {
            string z = i.ToString();
            if (z[0] == '5' || z[0] == '3')
            {
                long dig = 0;
                long rev = 0;
                long num = i;

                while (num > 0)
                {
                    dig = num % 10;
                    rev = rev * 10 + dig;
                    num = num / 10;
                }
                if (i == rev)
                    counter++;
            }
        }
        return counter;
    }
}
