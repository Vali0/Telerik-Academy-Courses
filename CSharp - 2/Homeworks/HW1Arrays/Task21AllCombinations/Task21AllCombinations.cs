using System;

class AllCombinations
{
    /* Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
    Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}*/
    
    static void Main()
    {
        int setOfNumbers;
        Console.WriteLine("Enter end of the set [1...N]: ");
        setOfNumbers = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K distinct elements: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        Combinations(array, 0, 1, setOfNumbers);
    }

    static void Combinations(int[] array, int index, int currentNumber, int n)
    {
        if (index == array.Length)
        {
            Print(array);
        }
        else
        {
            for (int i = currentNumber; i <= n; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i + 1, n);
            }
        }
    }

    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}