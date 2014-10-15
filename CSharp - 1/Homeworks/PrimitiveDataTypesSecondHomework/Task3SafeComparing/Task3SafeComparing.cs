using System;

class Task3SafeComparing
{
    static void Main(string[] args)
    {
        //Declarating variables which type is decimal for bigger precision
        decimal firstNumber = 0m;
        decimal secondNumber = 0m;

        Console.WriteLine("Enter value of the first number: ");
        firstNumber = decimal.Parse(Console.ReadLine()); // Reading number from console
        Console.WriteLine("Enter values of the second number: ");
        secondNumber = decimal.Parse(Console.ReadLine()); // Reading number from console

        // if statemant starts here
        if (firstNumber > secondNumber)
        {
            Console.WriteLine("First number (" + firstNumber + ") is bigger than second (" + secondNumber + ")");
        }
        else if (firstNumber < secondNumber)
        {
            Console.WriteLine("Second number (" + secondNumber + ") is bigger than first (" + firstNumber + ")");
        }
        else
            Console.WriteLine("They are equal");
        // if statemant ends here
    }
}

