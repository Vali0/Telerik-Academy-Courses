using System;

class VariationsGenerator
{
    const int n = 4;
    const int k = 2;
    static int[] objects = new int[n] 
	{
		1,2,3,4
	};
    static int[] arr = new int[k];

    static void Main()
    {
        GenerateVariationsWithRepetitions(0);
    }

    static void GenerateVariationsWithRepetitions(int index)
    {
        if (index >= k)
        {
            PrintVariations();
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                arr[index] = i;
                GenerateVariationsWithRepetitions(index + 1);
            }
        }
    }

    static void PrintVariations()
    {
        Console.Write("(" + String.Join(", ", arr) + ") --> ( ");
        
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(objects[arr[i]] + " ");
        }
        Console.WriteLine(")");
    }
}
