using System;

class Task05GreaterNumber
{
    static void Main(string[] args)
    {
        int firstNumber, secondNumber;
        Console.WriteLine("Enter first number: ");
        firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        secondNumber = int.Parse(Console.ReadLine());
        Console.Write("\nGreater number is: "); // Just a string to which we will concatinate the result
        Console.WriteLine(firstNumber>secondNumber ? firstNumber : secondNumber); // Printing the result
    }
}
