using System;

// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

class Task01aOrdinaryMatrix
{
    static void Main(string[] args)
    {
        int size = 0;
        int member = 1;
        Console.WriteLine("Enter size of your matrix: ");
        size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size]; // Defining the matrix

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[j, i] = member++; //Adding members by rows - [j,i]
            }
        }
        Print(matrix);
    }

    //Print the matrix
    static void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != matrix.GetLength(1) - 1)
                    Console.Write(matrix[i, j] + " ");
                else
                    Console.WriteLine(matrix[i, j]); // Last element of the row
            }
        }
    }
    // Other solution
    /*static void Main(string[] args)
    {
    int size = 0;
    int element = 0;
    Console.WriteLine("Enter size of your matrix: ");
    size = int.Parse(Console.ReadLine());
    for (int i = 1; i <= size; i++)
    {
    element = i;
    for (int j = 0; j < size; j++)
    {
    Console.Write(element+ " ");
    element += size;
    }
    Console.WriteLine();
    }
    }*/
}