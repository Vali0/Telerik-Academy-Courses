using System;

//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100


class Task02LevelException
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter start: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end: ");
            int end = int.Parse(Console.ReadLine());

            BoundsCheck(start, end); // Checking bounds

            byte[] numbers = new byte[10]; // If all is good with bounds making an array
            numbers = ReadNumber(start, end); // Fill the array

            Console.WriteLine("Your input looks like that: ");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
        catch (FormatException format)
        {
            Console.WriteLine(format.Message); // If your input is wrong
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }

    public static byte[] ReadNumber(int start, int end)
    {
        byte[] numbers = new byte[10];
        Console.WriteLine("Fill your array with numbers in range of ({0};{1})", start, end);
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter your number: ");
            numbers[i] = byte.Parse(Console.ReadLine());
            if (numbers[i] <= start || numbers[i] >= end) // throw exception if the inputted number isn't in bounds
                throw new ArgumentOutOfRangeException("This number isnt't in bounds!");
        }
        return numbers; // Returning array to Main
    }

    public static void BoundsCheck(int start, int end)
    {
        if (start < 1 || end > 100)
            throw new ArgumentOutOfRangeException("\"Start\" and \"end\" aren't in bounds (1;100)");
        else if (start > end)
            throw new ArgumentOutOfRangeException("Wrong bounds. \"Start\" is bigger than \"end\"!");
    }
}