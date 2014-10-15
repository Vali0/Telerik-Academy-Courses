using System;

class Task10SpecificSumInSequence
{
    /*
    * Write a program that finds in given array of integers a sequence of given sum S (if present). 
    * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}	
    */
    static void Main()
    {
        int sum = 0;
        int currentSum = 0;
        Console.WriteLine("Enter the specific sum that you want to search: ");
        sum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter size of your array: ");
        int size = int.Parse(Console.ReadLine()); //Getting array size
        int[] array = new int[size];

        Console.WriteLine("Initialize your array");
        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}]= ", i);
            array[i] = int.Parse(Console.ReadLine()); //Initializing the array
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i; j++) // array.Length -i -> need to be done because index out of bound exception
            {
                currentSum += array[i + j];   // 'i' is the first member from the sequence (from it we start to sum)
                if (currentSum == sum)
                {
                    for (int start = i; start < i + j + 1; start++)
                    {
                        if (start != i + j)
                            Console.Write(array[start] + ", ");
                        else
                            Console.WriteLine(array[start]);
                    }
                }
            }
            currentSum = 0; 
        }
    }
}