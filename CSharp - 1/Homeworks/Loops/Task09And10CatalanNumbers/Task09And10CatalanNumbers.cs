using System;
using System.Numerics;

class Task09And10CatalanNumbers
{
    static void Main(string[] args)
    {
        // Defining and initializing the number
        int member = 0;
        Console.WriteLine("Enter member which you want to calculate with Catalan's formula: ");
        member = int.Parse(Console.ReadLine()); // Reading the number
        Console.WriteLine(CatalanFormula(2*member) / ((CatalanFormula(member+1)*CatalanFormula(member)))); // Calculating the number with recursion again
    }
    public static BigInteger CatalanFormula(int n) // BigInteger just for sure
    {
        BigInteger catalanNumber = 1;
        for (int i = n; i > 0; i--)
        {
           catalanNumber *= i; // Just calculating the factorials
        }
        return catalanNumber;
    }
}
