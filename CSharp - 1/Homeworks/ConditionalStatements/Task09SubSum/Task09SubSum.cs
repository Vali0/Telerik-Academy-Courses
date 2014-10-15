using System;
using System.Collections;

class Task09SubSum
{
    static void Main(string[] args)
    {

        int[] numbers = new int[5]; // Here I save my numbers
        int currentSum = 0; // Here I keep the sum
        ArrayList indexes = new ArrayList(); // Here I keep the indexes of the numbers which sum is 0
        // I use ArrayList because I don't know how many numbers will make '0' sum

        // Filling the array
        for (int i = 0; i < 5; i++) 
        {
            Console.WriteLine("Enter {0} number: ", (i + 1));
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // I get the logic of the task by that video: http://www.youtube.com/watch?v=Sk0PX0YSHtk
        // There is very well explained so I won't do that
        for (int i = 1; i <= (Math.Pow(2, 5) - 1); i++)
        {
            currentSum = 0; // Must redefine the sum
            indexes.Clear(); // I clear my ArrayList
            for (int j = 0; j < 5; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;

                if (bit == 1)
                {
                    currentSum += numbers[j]; // Filling the sum
                    indexes.Add(j); // Remember the index of the number
                }
            }

            if (currentSum == 0)
            {
                Console.Write("The sum of the numbers: ");
                foreach (int c in indexes)
                    Console.Write(numbers[c] + " "); // Printing numbers which sum is '0'
                Console.WriteLine("is zero!");
            }
        }
    }
}
