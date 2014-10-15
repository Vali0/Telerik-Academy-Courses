using System;

// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

class Task01cDiagonalMatrix
{
    static void Main(string[] args)
    {
        int size = 0;
        int member = 1;
        int row = 0;
        int col = 0;
        Console.WriteLine("Enter size of your matrix: ");
        size = int.Parse(Console.ReadLine());
        
        //Defining the matrix
        int[,] matrix = new int[size, size];

        // Filling bellow primary diagonal
        for (int i = size - 1; i >= 0; i--)
        {
            row = i;
            do
            {
                matrix[row, col] = member++;
                row++;
                col++;
            }
            while (row < size);
            col = 0;
        }

        // Above primary diagonal
        for (int i = 1; i < size; i++)
        {
            row = 0;
            col = i;
            do
            {
                matrix[row, col] = member++;
                col++;
                row++;
            }
            while (col < size);
        }

        //Print the matrix
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