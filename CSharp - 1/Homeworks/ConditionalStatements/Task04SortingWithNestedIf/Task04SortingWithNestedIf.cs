using System;

class Task04SortingWithNestedIf
{
    static void Main(string[] args)
    {
        try
        {
            // Defining varuables
            double firstNumber, secondNumber, thirdNumber;

            // Initializing variables
            Console.WriteLine("Enter first number: ");
            firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            thirdNumber = double.Parse(Console.ReadLine());

            // symbol '=' is for equal numbers
            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                if (secondNumber >= thirdNumber)
                    Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber);
                else
                    Console.WriteLine(firstNumber + " " + thirdNumber + " " + secondNumber);
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                if (firstNumber >= thirdNumber)
                    Console.WriteLine(secondNumber + " " + firstNumber + " " + thirdNumber);
                else
                    Console.WriteLine(secondNumber + " " + thirdNumber + " " + firstNumber);
            }
            else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
            {
                if (firstNumber >= secondNumber)
                    Console.WriteLine(thirdNumber + " " + firstNumber + " " + secondNumber);
                else
                    Console.WriteLine(thirdNumber + " " + secondNumber + " " + firstNumber);
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }
    }
}
