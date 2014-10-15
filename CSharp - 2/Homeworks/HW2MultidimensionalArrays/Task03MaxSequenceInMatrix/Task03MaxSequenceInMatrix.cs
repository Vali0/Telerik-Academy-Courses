using System;

/*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several
* neighbor elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.*/

class Task03MaxSequenceInMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter how many rows will have your matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many cols will have your matrix: ");
        int cols = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];
        Console.WriteLine("Initializing your matrix");
        //Method for filling the matrix
        FillMatrix(matrix);

        Console.WriteLine("\nYour matrix looks like that");
        //Printed your matrix
        PrintMatrix(matrix);

        // Directions
        byte colsSequence = 0;
        byte rowsSequence = 1;
        byte diagonalRight = 2;
        byte diagonalLeft = 3;

        int[,,] tempMatrix = new int[rows, cols, 4]; // Last dimention is the direction

        int maximalLength = 0;
        int bestRow = 0, bestCol = 0;

        // Loops to perambulate the matrix rows,cols and diagonals
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    tempMatrix[i, j, k] = 1;
                }

                if (i > 0 && matrix[i, j] == matrix[i - 1, j])
                {
                    tempMatrix[i, j, colsSequence] = tempMatrix[i - 1, j, colsSequence] + 1;
                }
                if (j > 0 && matrix[i, j] == matrix[i, j - 1])
                {
                    tempMatrix[i, j, rowsSequence] = tempMatrix[i, j - 1, rowsSequence] + 1;
                }
                if (i > 0 && j > 0 && matrix[i, j] == matrix[i - 1, j - 1])
                {
                    tempMatrix[i, j, diagonalRight] = tempMatrix[i - 1, j - 1, diagonalRight] + 1;
                }
                if (i > 0 && j < cols - 1 && matrix[i, j] == matrix[i - 1, j + 1])
                {
                    tempMatrix[i, j, diagonalLeft] = tempMatrix[i - 1, j + 1, diagonalLeft] + 1;
                }

                for (int k = 0; k < 4; ++k)
                {
                    if (tempMatrix[i, j, k] > maximalLength)
                    {
                        maximalLength = tempMatrix[i, j, k];
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }
        }

        Console.WriteLine("\nThe longest sequence is with length: " + maximalLength);
        Console.Write("The sequence is made by: ");
        for (int i = 0; i < maximalLength; i++)
        {
            if (i != maximalLength - 1)
                Console.Write(matrix[bestRow, bestCol] + ", ");
            else
                Console.WriteLine(matrix[bestRow, bestCol] + ";");
        }
    }

    // Method to fill the matrix
    static void FillMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                Console.Write("matrix[{0},{1}] = ", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }
    }

    // Method to print the matrix
    static void PrintMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != matrix.GetLength(1) - 1)
                    Console.Write(matrix[i, j] + " ");
                else
                    Console.WriteLine(matrix[i, j]); // Last elelent
            }
        }
    }
}