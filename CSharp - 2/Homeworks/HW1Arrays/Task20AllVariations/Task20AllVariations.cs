using System;

class Task20AllVariations
{
    /* Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
    * Example:	N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3} */
    static void Main()
    {
        int setOfNumbers;
        Console.WriteLine("Enter end of the set [1...N]): ");
        setOfNumbers = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many members will have each variation: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        Variation(array, setOfNumbers, 0);
    }
    
    static void Variation(int[] array, int n, int i)
    {
        if (i == array.Length)
        {
            Print(array);
            return;
        }

        for (int j = 0; j < n; j++)
        {
            array[i] = j;
            Variation(array, n, i + 1);
        }
    }
    
    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + 1 + (i == array.Length - 1 ? "\n" : " "));
    }
}