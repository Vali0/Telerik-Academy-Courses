using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BigInteger firstNumber, secondNumber, thirdNumber;
        firstNumber = BigInteger.Parse(Console.ReadLine());
        secondNumber = BigInteger.Parse(Console.ReadLine());
        thirdNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger nthNumber = 0;
        short n = short.Parse(Console.ReadLine());

        if (n > 3)
            for (int i = 3; i < n; i++)
            {
                nthNumber = firstNumber + secondNumber + thirdNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = nthNumber;
            }
        else if (n == 1)
            nthNumber = firstNumber;
        else if (n == 2)
            nthNumber = secondNumber;
        else if (n == 3)
            nthNumber = thirdNumber;
        else if (n == 0)
            nthNumber = 0;
        Console.WriteLine(nthNumber);
    }
}
