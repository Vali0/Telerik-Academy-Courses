using System;

//Write a program that reads a rectangular matrix of size N x M 
//and finds in it the square 3 x 3 that has maximal sum of its elements.

class Task02MaxSumOfSubSquareMatrix
{
    static void Main(string[] args)
    {
        int rows, cols;
        int sum = 0;
        int oldSum = 0;
        int maxRow = 0;
        int maxCol = 0;
        Console.WriteLine("Enter how many rows will have your rectangular: ");
        rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many cols will have your rectangular: ");
        cols = int.Parse(Console.ReadLine());
        //Defining the matrix
        int[,] rectangularMatrix = new int[rows, cols];
        
        Random rand = new Random(); // for generating the matrix members

        // Initializing the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                rectangularMatrix[i, j] = rand.Next(0, 10);
            //rectangularMatrix[i,j] = int.Parse(Console.ReadLine()); // If you want manual input
        }
        for (int i = 0; i <= rows - 3; i++)
        {
            for (int j = 0; j <= cols - 3; j++)
            {
                oldSum = 0;
                oldSum = CalculatingSum(rectangularMatrix, i, j);
                if (oldSum > sum)
                {
                    sum = oldSum;
                    maxRow = i;
                    maxCol = j;
                }
            }
        }
        Console.WriteLine("Your inputted matrix looks like this: ");
        Print(rectangularMatrix);

        Console.WriteLine("\nSquare matrix with biggest sum of {0} is: ", sum);
        MaxSumSquarePrint(rectangularMatrix, maxRow, maxCol);
    }

    // Method for calculating the sum.
    static int CalculatingSum(int[,] matrix, int row, int col)
    {
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sum += matrix[i + row, j + col];
            }
        }
        return sum;
    }

    // Method for printing the matrix
    static void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != matrix.GetLength(1) - 1)
                    Console.Write(matrix[i, j] + " ");
                else
                    Console.WriteLine(matrix[i, j]); // Last member
            }
        }
    }

    // Method for filling the square matrix with biggest sum members
    static void MaxSumSquarePrint(int[,] matrix, int row, int col)
    {
        int[,] squareMatrix = new int[3, 3]; // Square matrix (3x3 by task)
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                squareMatrix[i, j] = matrix[i + row, j + col];   
            }
        }
        Print(squareMatrix); // Printing the square matrix
    }
}