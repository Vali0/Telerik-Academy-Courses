using System;
using System.Collections.Generic;

class Task03MinAndMaxNumber
{
    static void Main(string[] args)
    {
        int loopLimit = 0;
        Console.WriteLine("Enter how many numbers you want to have: ");
        loopLimit = int.Parse(Console.ReadLine()); // How many numbers will you have
        int[] array = new int[loopLimit];
        for (int i = 0; i < loopLimit; i++)
        {
            Console.WriteLine("Enter {0} number: ", (i + 1));
            array[i] = int.Parse(Console.ReadLine()); // Filling the array with numbers
        }
        Array.Sort(array); // I use array sort to get min and max element
        Console.WriteLine("minimal member is: " + array[0] + " maximum member is: " + array[loopLimit - 1]); // Printing min and max element
    }
}