using System;

class Task19Permutations
{
    /* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
    Example:n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}*/
    static void Main()
    {
        Console.WriteLine("Enter how many elements will have the permutations: ");
        int[] array = new int[int.Parse(Console.ReadLine())];

        bool[] alreadyChecked = new bool[array.Length]; //used
        Permutation(array, alreadyChecked, 0);
    }

    static void Permutation(int[] array, bool[] alreadyChecked, int i)
    {
        if (i == array.Length)
        {
            Print(array);
            return;
        }

        for (int j = 0; j < array.Length; j++)
        {
            if (alreadyChecked[j])
                continue;

            array[i] = j;

            alreadyChecked[j] = true;
            Permutation(array, alreadyChecked, i + 1);
            alreadyChecked[j] = false;
        }
    }

    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + 1 + (i == array.Length - 1 ? "\n" : " "));
    }
}