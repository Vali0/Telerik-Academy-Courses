using System;
using System.Linq;

/* Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
*/

class Task13ComplexProgram
{
    static void Main(string[] args)
    {
        int choice = 0; // User choice

        // do-while statement for menu
        do
        {
            Console.WriteLine(new String('-', 20) + "MENU" + new String('-', 20));
            Console.WriteLine("1. Reverse number digits");
            Console.WriteLine("2. Calculate the average of a sequence");
            Console.WriteLine("3. Solve a linear equation");
            Console.WriteLine(new String('-', 11) + "Ctrl+C or '9' for exit" + new String('-', 11));
            choice = int.Parse(Console.ReadLine());
            UserChoice(choice); // Call method user choice which is switch statement
        }
        while (choice != 9);
    }

    //Actualy this is Task07, so i won't explain
    static void ReversingDecimal()
    {
        decimal number = 0m;
        do
        {
            Console.WriteLine("Enter your decimal number: ");
            number = decimal.Parse(Console.ReadLine());
        }
        while (number < 0);

        string stringNumber = number.ToString();
        char[] charOfTheNumber = stringNumber.ToCharArray();
        Array.Reverse(charOfTheNumber);
        string result = new string(charOfTheNumber);

        Console.WriteLine("After reversing number looks like this: " + result);
        Console.WriteLine();
    }

    static void AverageOfSequence()
    {
        int sizeOfSequence = 0;
        // do-while statement to perform task requirement
        do
        {
            Console.WriteLine("Enter how big will be your sequence: ");
            sizeOfSequence = int.Parse(Console.ReadLine());
        }
        while (sizeOfSequence < 1);

        Console.WriteLine("Initialize your sequence");
        int[] sequenceMembers = FillSequence(sizeOfSequence); // Initializing array which size is inputted

        decimal average = (decimal)sequenceMembers.Average(); //Calculating the average sum using Linq
        Console.WriteLine("The average of the sequence is: " + average); //Printing it
        Console.WriteLine(); // Just new line
    }

    static void SolveLinearEquation()
    {
        decimal aCoef = 0;
        decimal bCoef = 0;

        // do-while statement to perform task requirement a>0
        do
        {
            Console.WriteLine("Enter 'a' coefficient of the equation (a*x+b = 0): ");
            aCoef = decimal.Parse(Console.ReadLine());
        }
        while (aCoef <= 0);
        Console.WriteLine("Enter your 'b' coefficient of the quation  (a*x+b = 0): ");
        bCoef = decimal.Parse(Console.ReadLine());
        Console.WriteLine("The line 'x' is with value: " + ((-1) * bCoef) / aCoef);
        Console.WriteLine();
    }

    // Simple method to get user choice and call the method accurate method
    static void UserChoice(int choice)
    {
        switch(choice)
        {
            case 1:
                ReversingDecimal();
                break;
            case 2:
                AverageOfSequence();
                break;
            case 3:
                SolveLinearEquation();
                break;
            case 9:
                break;
            default:
                Console.WriteLine("Wrong choice!");
                break;
        }
    }

    // Method to fill the array used in case 2
    static int[] FillSequence(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
}