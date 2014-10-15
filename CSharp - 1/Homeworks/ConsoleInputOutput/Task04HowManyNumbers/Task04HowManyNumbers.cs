using System;

class Task04HowManyNumbers
{
    static void Main(string[] args)
    {
        uint leftInt, rightInt;
        int reminderCounter = 0;
        Console.WriteLine("Enter first number: ");
        leftInt = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        rightInt = uint.Parse(Console.ReadLine());

        if (leftInt <= rightInt) // Check that if the first entered number is less or equal than second
        {
            for (uint i = leftInt; i <= rightInt; i++)
            {
                if (i % 5 == 0)
                    reminderCounter++;
            }
        }
        else // When first is greater than second (could use value exchange but its not neccessery)
        {
            for (uint i = rightInt; i <= leftInt; i++)
            {
                if (i % 5 == 0)
                    reminderCounter++;
            }
        }
        Console.WriteLine("There are: " + reminderCounter + " numbers which division by 5 is 0"); // Printing what need to be printed
    }
}