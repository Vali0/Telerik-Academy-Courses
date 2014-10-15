using System;

class Task08GCD
{
    static void Main(string[] args)
    {
        try
        {
            // Defining and initializing the two numbers
            int firstNumber, secondNumber;
            Console.WriteLine("Enter first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GCD(firstNumber, secondNumber)); // Calculating the GCD using simple recursion
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered symbol or letter!");
        }
    }
    public static int GCD(int first, int second)
    {
        if (second == 0)
            return first;
        else
            return GCD(second, first % second);
    }
}
