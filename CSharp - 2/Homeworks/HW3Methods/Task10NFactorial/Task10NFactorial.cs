using System;
using System.Numerics;

/* Write a program to calculate n! for each n in the range [1..100]. 
* Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. */

class Task10NFactorial
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
            Console.WriteLine(Factorial(i)); // Printing the result of each member factorial
    }

    static BigInteger Factorial(int number)
    {
        BigInteger result = 1;
        
        // Simple loop to calculate the factorial
        for (int i = number; i > 0; i--)
        {
            result = result * i;
        }
        return result;
    }
}