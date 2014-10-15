using System;
using System.Numerics;


class Program
{
    static void Main(string[] args)
    {

        BigInteger number = BigInteger.Parse(Console.ReadLine());
        if (number < 0)
            number = (-1) * number;
        BigInteger oldNumber = number;
        BigInteger oddSum = 0;
        BigInteger evenSum = 0;
        BigInteger counter = 1;

        while (number != 0)
        {
            if (counter % 2 == 0)
            {
                evenSum = evenSum + ((number % 10) * (number % 10 )) * (counter);
            }
            else
            {
                oddSum = oddSum + (number % 10) * (counter * counter);
            }
            number = number / 10;
            counter++;
        }
        BigInteger specialSum = evenSum + oddSum;
        Console.WriteLine(specialSum);
        BigInteger end = specialSum % 10;
        if (end == 0)
        {
            Console.WriteLine(oldNumber + " has no secret alpha-sequence");
        }
        else
        {
            BigInteger R = (specialSum % 26);
            BigInteger i = 0;

            BigInteger firstLetter = specialSum + R + 1;

            while (end > 0)
            {
                if ((char)(R + i + 'A') >= 'Z')
                {
                    Console.Write((char)(R + 1 + i + (int)'A' - 1));
                    R = 0;
                    i = 0;
                    --end;
                }
                else
                {
                    Console.Write((char)(R + 1 + i + (int)'A' - 1));
                    --end;
                    i++;
                }
            }
            Console.WriteLine();
        }
    }
}
