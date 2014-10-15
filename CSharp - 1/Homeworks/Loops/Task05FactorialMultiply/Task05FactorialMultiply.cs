using System;
using System.Numerics;

class Task05FactorialMultiply
{
    static void Main(string[] args)
    {
        int multiplicand, multiplier;

        // Big integer values for factoriels because I don't know how big is your imagination ;)
        BigInteger multiplicandFactorial = 1;
        BigInteger multiplierFactorial = 1;
        try
        {
            // do-while statement for multiplicand constraints
            do
            {
                Console.WriteLine("Enter your multiplicand: ");
                multiplicand = int.Parse(Console.ReadLine());
            } while (multiplicand < 2);

            // do-while statement for multiplier constraints
            do
            {
                Console.WriteLine("Enter your multiplier: ");
                multiplier = int.Parse(Console.ReadLine());
            } while (multiplier < multiplicand);

            for (int i = multiplicand; i > 0; i--)
                multiplicandFactorial *= i; // Calculating multiplicand factorial

            for (int i = multiplier; i > 0; i--)
                multiplierFactorial *= i; // Calculating multiplier factorial

            Console.WriteLine("The result is: " + (multiplicandFactorial * multiplierFactorial) / (multiplier - multiplicand)); // Printing the result
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }
    }
}