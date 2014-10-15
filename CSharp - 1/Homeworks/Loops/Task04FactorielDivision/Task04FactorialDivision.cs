using System;
using System.Numerics;

class Task04FactorialDivision
{
    static void Main(string[] args)
    {
        int dividend, divider;
        // Big integer values for factoriels because I don't know how big is your imagination ;)
        BigInteger dividendFactorial = 1;
        BigInteger dividerFactorial = 1;
        try
        {
            // do-while statement for dividend constraints
            do
            {
                Console.WriteLine("Enter dividend value: ");
                dividend = int.Parse(Console.ReadLine());
            } while (dividend < 2);

            // do-while statement for divider constraints
            do
            {
                Console.WriteLine("Enter divider value: ");
                divider = int.Parse(Console.ReadLine());
            } while (divider < 2 || divider > dividend - 1);

            for (int i = dividend; i > 0; i--)
                dividendFactorial *= i; // Calculating dividend factorial

            for (int i = divider; i > 0; i--)
                dividerFactorial *= i; // Calculating divider factorial

            Console.WriteLine("The result is: " + dividendFactorial / dividerFactorial); // Printing the result
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }
    }
}