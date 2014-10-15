using System;

class Task08MaxSumInSequence
{
    /*
    * Write a program that finds the sequence of maximal sum in given array. Example:
    {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
    */
    static void Main(string[] args)
    {
        // !!!IMPORTANT!!!                    !!!IMPORTANT!!!                         !!!IMPORTANT!!!
        // THIS PROGRAM COULD NOT RUN WITH OLDER VISUAL STUDIO THAN 2012 OR IF YOU DON'T HAVE .NET 4.5!!!
        // BECAUSE TUPLE CLASS (LOOK AT THE END)!!!
        // !!!IMPORTANT!!!                    !!!IMPORTANT!!!                         !!!IMPORTANT!!!
        Console.WriteLine("Enter size of your array: ");
        int size = int.Parse(Console.ReadLine()); //Getting array size
        int[] array = new int[size];
        Console.WriteLine("Initialize your array");

        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}]= ", i);
            array[i] = int.Parse(Console.ReadLine()); //Initializing the array
        }

        int max = 0;
        int sequenceStart = 0;
        int sequenceCounter = 0;
        maxSum(array, out max, out sequenceStart, out sequenceCounter); // Calling the method maxSum
        // !!!It is void and must be called without assign, but it use Tuple class!!!
        
        Console.WriteLine("The max sum is: " + max);
        Console.Write("Elements that make the sum are: ");

        for (int i = sequenceStart; i < sequenceStart + sequenceCounter; ++i)
        {
            if (i != sequenceStart + sequenceCounter - 1)
                Console.Write(array[i] + ", ");
            else
                Console.WriteLine(array[i]);
        }
    }

    // Kadane's algorithm starts here!
    // You can read more about it here: http://en.wikipedia.org/wiki/Maximum_subarray_problem
    public static void maxSum(int[] array, out int max, out int sequenceStart, out int sequenceCounter)
    {
        int maxEnd = array[0];
        int oldSequenceCounter = 1;
        int oldSequenceStart = 0;
        max = 0;
        sequenceStart = 0;
        sequenceCounter = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (maxEnd < 0)
            {
                maxEnd = array[i];
                oldSequenceStart = i;
                oldSequenceCounter = 1;
            }
            else
            {
                maxEnd += array[i];
                oldSequenceCounter++;
            }
            if (maxEnd > max)
            {
                max = maxEnd;
                sequenceCounter = oldSequenceCounter;
                sequenceStart = oldSequenceStart;
            }
        }
    }

    // Tuple class implementation
    // Read about it here: http://msdn.microsoft.com/en-us/library/system.tuple.aspx
    // This method could not run in older versions (need .NET 4.5 Visual Studio 2012)
    static Tuple<int, int, int> maxSum()
    {
        return new Tuple<int, int, int>(1, 2, 3);
    }
}