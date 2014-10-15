using System;

// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

class Task01bOrdinaryMatrix
{
    static void Main(string[] args)
    {
        int size = 0;
        int member = 1;
        Console.WriteLine("Enter size of your matrix: ");
        size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            if (i % 2 == 0) // Every even column starts from the top
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[j, i] = member++; // Adding members by rows
                }
            }
            else //Every odd column starts from the bottom
            {
                for (int j = size - 1; j >= 0; j--)
                {
                    matrix[j, i] = member++; // Adding members by rows
                }
            }
        }

        //Printing the matrix
        Print(matrix);
    }

    // Print method
    static void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != matrix.GetLength(1) - 1)
                    Console.Write(matrix[i, j] + " ");
                else
                    Console.WriteLine(matrix[i, j]); // Last member of the row
            }
        }
    }
}