using System;

class Task06Sum
{
    static void Main(string[] args)
    {
        try
        {

            // Defining variables
            int divider = 0;
            byte members = 0;
            double sum = 1;

            // Initializing variables
            Console.WriteLine("Enter how many members you want to sum: ");
            members = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter divider value: ");
            divider = int.Parse(Console.ReadLine());

            for (int i = 1; i <= members; i++)
                sum = sum + Factoriel(i) / Math.Pow(divider, i); // Calculating the sum using recursive method Factoriel

            Console.WriteLine("The sum is: " + sum); // Printing the sum
        }
        catch (FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }
    }
    public static int Factoriel(int member)
    {
        int memberFactoriel = 1;

        for (int i = member; i > 0; i--)
            memberFactoriel *= i;

        return memberFactoriel;
    }
}