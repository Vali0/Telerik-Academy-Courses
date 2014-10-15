using System;

/* Write a method that counts how many times given number appears in given array. 
* Write a test program to check if the method is working correctly.*/

public class Task04NumberCounter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of your array: ");
        int[] numbers = new int[int.Parse(Console.ReadLine())];

        Console.WriteLine("Initializing your array");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("number[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter element which one you want to count: ");
        int element = int.Parse(Console.ReadLine());

        int occur = ElementCounting(numbers, element); // Calling element counter method

        Console.WriteLine("\nThere is {0} members like {1}", occur, element); // Printing the counter and element value
    }

    public static int ElementCounting(int[] array, int element)
    {
        int counter = 0;

        //Simple loop to check the array
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
                counter++;
        }
        return counter; // Return counter
    }
}