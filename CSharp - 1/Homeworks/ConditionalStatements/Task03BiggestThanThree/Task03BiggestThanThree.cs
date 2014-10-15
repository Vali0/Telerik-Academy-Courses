using System;

class Task03BiggestThanThree
{
    static void Main(string[] args)
    {
        try
        {
            // Defining varuables
            int firstNumber, secondNumber, thirdNumber;

            // Initializing variables
            Console.WriteLine("Enter first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            thirdNumber = int.Parse(Console.ReadLine());

            // First if starts here
            // return; in every if stop the program, this prevent computer to check other if statemants
            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("First number {0} is biggest!", firstNumber);
                    return;
                }
                else
                {
                    Console.WriteLine("Third number {0} is biggest!", thirdNumber);
                    return;
                }
            }
            // First if ends here

            // Second if starts here
            if (firstNumber < secondNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("Second number {0} is biggest!", secondNumber);
                    return;
                }
                else
                {
                    Console.WriteLine("Third number {0} is biggest!", thirdNumber);
                    return;
                }
            }
            // Second if ends here

            // Third if starts here
            if (firstNumber > thirdNumber)
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine("First number {0} is biggest!", firstNumber);
                    return;
                }
                else
                {
                    Console.WriteLine("Second number {0} is biggest!", secondNumber);
                    return;
                }
            }
            // Third if ends here

            // Fourth if starts here
            if (firstNumber < thirdNumber)
            {
                if (thirdNumber > secondNumber)
                {
                    Console.WriteLine("Third number {0} is biggest!", thirdNumber);
                    return;
                }
                else
                {
                    Console.WriteLine("Second number {0} is biggest!", secondNumber);
                    return;
                }
            }
            // Fourth if ends here

            // Fifth if starts here
            if (secondNumber > thirdNumber)
            {
                if (secondNumber > firstNumber)
                {
                    Console.WriteLine("Second number {0} is biggest!", secondNumber);
                    return;
                }
                else
                {
                    Console.WriteLine("First number {0} is biggest!", firstNumber);
                    return;
                }
            }
            // Fifth if ends here

            // Sixth if starts here
            if (secondNumber < thirdNumber)
            {
                if (thirdNumber > firstNumber)
                {
                    Console.WriteLine("Third number {0} is biggest!", thirdNumber);
                    return;
                }
                else
                {
                    Console.WriteLine("First number {0} is biggest!", firstNumber);
                    return;
                }
            }
            // Sixth if ends here

            // Just in case if you enter three equal numbers
            if(firstNumber == secondNumber && firstNumber == thirdNumber)
                Console.WriteLine("The numbers are equal");
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }
    }
}