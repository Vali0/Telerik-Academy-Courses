using System;

/* Write a method that checks if the element at given position in given array of integers is bigger 
* than its two neighbors (when such exist). */

class Task05NumberNeighbors
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

        int index = 0;
        // do-while to get valid index
        do
        {
            Console.WriteLine("Enter index of the array (counting from 0): ");
            index = int.Parse(Console.ReadLine());
        }
        while (index < 1 || index > numbers.Length - 2);

        ElementNeighbors(numbers, index);
        //Console.WriteLine(ElementNeighbors(numbers, index)); // Call the method with second solution
    }

    //This method could be made from boolean type and to return true or false. Look at the end of page
    static void ElementNeighbors(int[] array, int index)
    {
        // Simple if statements with appropriate message
        if (array[index] > array[index - 1] && array[index] > array[index + 1])
        {
            Console.WriteLine("Element {0} with index {1} is bigger than its neighbors which are: {2} and {3}", array[index], index, array[index - 1], array[index + 1]);
        }
        else if (array[index] > array[index - 1] && array[index] < array[index + 1])
        {
            Console.WriteLine("Element {0} with index {1} is bigger than {2} with index {3} but less than {4} with index {5}", array[index], index, array[index - 1], index - 1, array[index + 1], index + 1);
        }
        else if (array[index] < array[index - 1] && array[index] > array[index + 1])
        {
            Console.WriteLine("Element {0} with index {1} is less than {2} with index {3} but bigger than {4} with index {5}", array[index], index, array[index - 1], index - 1, array[index + 1], index + 1);
        }
        else
        {
            Console.WriteLine("Element {0} with index {1} is equal to his neighbors (or to one of them)", array[index], index);
        }
    }
    //static bool ElementNeighbors(int[] array, int index)
    //{
    //    return (array[index] > array[index - 1] && array[index] > array[index + 1]);
    //}
}