using System;

/* Write a method that returns the index of the first element in array that is bigger than its neighbors,
* or -1, if there’s no such element. Use the method from the previous exercise. */

class Task06iOfFirstBiggerElement
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
        int index = ElementNeighbors(numbers); // Call the method
        Console.WriteLine("The index is(countring from '0'): " + index); // Printing index
    }

    static int ElementNeighbors(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
            if (array[i] > array[i - 1] && array[i] > array[i + 1]) // Simple neighbour check
            {
                return i;
            }
        return (-1);
    }
}