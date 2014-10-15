using System;
using System.Collections.Generic;

class Task02JoroTheRabbit
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] route = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = ConToInt(route);
        int maxRoute = 1;

        for (int startIndex = 0; startIndex < numbers.Length; startIndex++)
        {
            for (int step = 1; step < numbers.Length; step++)
            {
                int counter = 1;
                int index = startIndex;
                int next = (index + step) % numbers.Length;

                while (numbers[index] < numbers[next])
                {
                    counter++;
                    index = next;
                    next = (index + step) % numbers.Length;
                }
                maxRoute = GetMaxRoute(counter, maxRoute);
            }
        }
        
        Console.WriteLine(maxRoute);
    }
    
    public static int GetMaxRoute(int tempRoute, int maxRoute)
    {
        if (tempRoute < maxRoute)
        {
            return maxRoute;
        }
        
        return tempRoute;
    }

    public static int[] ConToInt(string[] str)
    {
        int[] numbers = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            numbers[i] = Convert.ToInt32(str[i]);
        }
        return numbers;
    }
}