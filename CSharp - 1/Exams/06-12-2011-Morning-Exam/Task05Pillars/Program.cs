using System;

class Program
{
    static void Main(string[] args)
    {
        int number, bit;
        int[,] grid = new int[8, 8];
        int numberAndMask, mask;
        int leftCounter = 0;
        int rightCounter = 0;

        for (int i = 0; i < 8; i++)
        {
            number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                mask = 1 << j;
                numberAndMask = number & mask;
                bit = (numberAndMask >> j);
                grid[i, 7 - j] = bit;
            }
        }

        for (int i = 0; i < 8; i++)
        {
            leftCounter = 0;
            rightCounter = 0;
            for (int m = 0; m < i; m++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (grid[j, m] == 1)
                    {
                        leftCounter++;
                    }
                }
            }
            for (int n = 7; n > i; n--)
            {
                for (int k = 0; k < 8; k++)
                {
                    if (grid[k, n] == 1)
                    {
                        rightCounter++;
                    }
                }
            }
            if ((leftCounter == rightCounter) && leftCounter!=0)
            {
                Console.WriteLine(7-i);
                Console.WriteLine(leftCounter);
                return;
            }
        }
            Console.WriteLine("No");
    }
}