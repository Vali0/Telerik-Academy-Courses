using System;
using System.Linq;

/*Write a method GetMax() with two parameters that returns the bigger of two integers.
* Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

class Task02BiggerInteger
{
    static void Main(string[] args)
    {
        int members, maxElement;
        Console.WriteLine("Enter how many members you will have: ");

        members = int.Parse(Console.ReadLine()); 
        int[] array = new int[members]; // Defining the array
        //I use array for that task. Could be used (params int[] arr)

        Console.WriteLine("Initialize your array");
        for (int i = 0; i < members; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        maxElement = GetMax(array); // Calling the method GetMax
        Console.WriteLine("The maximal element is: " + maxElement); // Printing the max element
    }

    static int GetMax(int[] array)
    {
        return array.Max(); // Linq method
    }
}