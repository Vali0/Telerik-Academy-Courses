using System;

class Program
{
    static void Main(string[] args)
    {
        long fixedSum = long.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        long sum = 0;
        int counter = 0;
        int mask, numberAndMask;
        byte bit;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        for (int i = 1; i < Math.Pow(2, n); i++)
        {
            sum = 0;
            for (int j = 0; j < n; j++)
            {
                mask = 1 << j;
                numberAndMask = i & mask;
                bit = (byte)(numberAndMask >> j);
                if (bit == 1)
                {
                    sum += numbers[j];
                }
            }
            if (sum == fixedSum)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}