using System;
using System.Collections;

class Task16SubSum
{
    /* We are given an array of integers and a number S. 
    Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
    arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)*/
    static void Main(string[] args)
    {
        int currentSum = 0;
        int tempSum = 0;
        int arraySize = 0;
        ArrayList indexes = new ArrayList(); // Here I keep the indexes of the numbers
        // I use ArrayList because I don't know how many numbers will make the sum
        
        Console.WriteLine("Enter how big will be your array: ");
        arraySize = int.Parse(Console.ReadLine());
        int[] numbers = new int[arraySize]; // Here I save my numbers

        // Filling the array
        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine("Enter {0} number: ", (i + 1));
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter what sum you want to search: ");
        currentSum = int.Parse(Console.ReadLine()); 

        // I get the logic of the task by that video: http://www.youtube.com/watch?v=Sk0PX0YSHtk
        // There is very well explained so I won't do that
        for (int i = 1; i <= (Math.Pow(2, arraySize) - 1); i++)
        {
            tempSum = 0; // Must redefine the sum
            indexes.Clear(); // I clear my ArrayList
            for (int j = 0; j < arraySize; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;

                if (bit == 1)
                {
                    tempSum += numbers[j]; // Filling the sum
                    indexes.Add(j); // Remember the index of the number
                }
            }

            if (tempSum == currentSum)
            {
                Console.Write("The sum of the numbers: ");
                foreach (int c in indexes)
                    Console.Write(numbers[c] + " "); // Printing numbers
                Console.WriteLine("is: {0}!", currentSum);
            }
        }
    }
}