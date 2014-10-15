using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        decimal number = decimal.Parse(Console.ReadLine());
        long sum = 0;

        if (number < 0)
            number = (-1) * number;

        while ((number * 10) % 10 != 0)
        {
            number = number * 10;
        }

    Again:
        while (number != 0)
        {
                sum += (long)(number % 10);
                number = number / 10;
        }
        
        if (sum > 9)
        {
            number = sum;
            sum = 0;
            goto Again;
        }
        else
            Console.WriteLine(sum);
    }
}