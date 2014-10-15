using System;

/*Write a method that return the maximal element in a portion of array of integers starting at given index. 
* Using it write another method that sorts an array in ascending / descending order.*/

class Task09MaxElementInArrayFromIndex
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of your array: ");
        int[] numbers = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("Initializing your array");
        
        Random rand = new Random(); // For initializing the array if you are lazy

        for (int i = 0; i < numbers.Length; i++)
        {
            //Console.Write("number[{0}] = ", i);
            //numbers[i] = int.Parse(Console.ReadLine());
            numbers[i] = rand.Next(-5, 15);
        }
        Console.WriteLine("Your array looks like this");
        Print(numbers); // Printing the inputted matrix

        // Selection sort algorithm with methods
        for (int i = 0; i < numbers.Length - 1; i++)
            GetMax(numbers, i);  

        Console.WriteLine();
        Console.WriteLine("After sorting in ascending order your array looks like this");
        Print(numbers);
        Console.WriteLine();

        Array.Reverse(numbers); // Reversing the matrix to get it in descending order
        Console.WriteLine("After sorting in descending order your array looks like this");
        Print(numbers);
    }

    static void GetMax(int[] array, int outIndex)
    {
        for (int j = outIndex + 1; j < array.Length; j++)
        {
            if (array[outIndex] > array[j])
            {
                Swap(array, outIndex, j); // Call method to swap the values
            }
        }
    }

    static void Swap(int[] array, int outIndex, int innnerIndex)
    {
        int temp = array[outIndex];             //Swapping
        array[outIndex] = array[innnerIndex];   //the elements
        array[innnerIndex] = temp;              // of array
    }

    //Print method
    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1)
                Console.Write(array[i] + ", ");
            else
                Console.WriteLine(array[i]);
        }
    }
}