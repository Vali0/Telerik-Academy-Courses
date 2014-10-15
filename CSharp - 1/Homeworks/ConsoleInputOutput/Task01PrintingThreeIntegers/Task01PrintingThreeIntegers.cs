using System;

class Task01PrintingThreeIntegers
{
    static void Main(string[] args)
    {
        // Initializing and reading their values from console.
        int firstNumber, secondNumber, thirdNumber, sum;
        Console.WriteLine("Enter first number value: ");
        firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number value: ");
        secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number value: ");
        thirdNumber = int.Parse(Console.ReadLine());

        sum = firstNumber + secondNumber + thirdNumber; // Calculating the sum
        Console.WriteLine("The sum is: " + sum);
    }
}
