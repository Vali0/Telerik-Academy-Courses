using System;

class Task01ExchangingValues
{
    static void Main(string[] args)
    {
        try
        {
            // Defining and intializing variables through console
            int firstNumber, secondNumber;
            Console.WriteLine("Enter first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                // I use bitwise operations for better speed and less memory
                firstNumber ^= secondNumber;
                secondNumber ^= firstNumber;
                firstNumber ^= secondNumber;

                //Printing swapped numbers
                Console.WriteLine("After swapping first number is: {0}, and second is: {1}", firstNumber, secondNumber);
            }
            else if (firstNumber == secondNumber)
                Console.WriteLine("The numbers are equal: " + firstNumber); // If they are equal
            else
                Console.WriteLine("There is no need to make swap so first number is: {0}, and second is: {1}", firstNumber, secondNumber); // When first is greater than second
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }
    }
}