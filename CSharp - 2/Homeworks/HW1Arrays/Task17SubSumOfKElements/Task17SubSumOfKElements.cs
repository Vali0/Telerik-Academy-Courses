using System;
using System.Collections;

class Task17SubSumOfKElements
{
    /* Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
    Find in the array a subset of K elements that have sum S or indicate about its absence. */
    static void Main(string[] args)
    {
        int currentSum = 0;
        int tempSum = 0;
        int arraySize = 0;
        int sumSize = 0;
        bool flag = false;
        ArrayList indexes = new ArrayList(); // Here I keep the indexes of the numbers

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

        do
        {
            Console.WriteLine("Enter how many numbers will make the sum: ");
            sumSize = int.Parse(Console.ReadLine());
        }
        while (sumSize < 1);
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

            if (tempSum == currentSum && indexes.Count == sumSize)
            {
                flag = true;
                Console.Write("The sum of the numbers: ");
                foreach (int item in indexes)
                    Console.Write(numbers[item] + " "); // Printing numbers
                Console.WriteLine("is: {0}!", currentSum);
            }
        }
        if (flag == false)
        {
            Console.WriteLine("There is no sub set of {0} elements which sum is {1}", sumSize, currentSum);
        }
    }
}