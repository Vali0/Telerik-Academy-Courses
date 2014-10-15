using System;

// * Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size.

class Task07LongestPath
{
    public static int longestPath = 0;
    public static int currentPath = 0;

    static void Main()
    {
        int rows, cols;
        Console.Write("Enter how many rows will have your matrix: ");
        rows = int.Parse(Console.ReadLine());
        Console.Write("Enter how many cols will have your matrix: ");
        cols = int.Parse(Console.ReadLine());
        
        // Defining the matrix. String because I will notice checked elements with "*"
        string[,] matrix = new string[rows, cols];

        Console.WriteLine("Initialize your matrix");
        FillTheMatrix(matrix);

        Console.WriteLine("Your matrix looks like that");
        Print(matrix);

        Console.WriteLine();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] != "*") // If I didn't move through that element
                {
                    currentPath = 0;
                    SearchPath(matrix, i, j); // See the path of the element

                    if (currentPath > longestPath)
                        longestPath = currentPath;
                }
            }
        }
        Console.WriteLine("Longest path is: {0}", longestPath);
    }

    public static void SearchPath(string[,] matrix, int i, int j)
    {
        string cellValue = matrix[i, j];
        matrix[i, j] = "*"; // Make the element checked
        currentPath++; // Increase the path
        for (int p = -1; p <= 1; p += 2)
        {
            if (CheckCell(matrix, i + p, j) && matrix[i + p, j] == cellValue)
            {
                SearchPath(matrix, i + p, j); // Recursive call
            }
            if (CheckCell(matrix, i, j + p) && matrix[i, j + p] == cellValue)
            {
                SearchPath(matrix, i, j + p); // Recursive call
            }
        }
    }

    //Fill the matrix
    static void FillTheMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("matrix[{0},{1}] = : ", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }
    }

    //Print the matrix
    static void Print(string[,] matrix)
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

    public static bool CheckCell(string[,] matrix, int x, int y)
    {
        return x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1); // Checking the cell is it on bounds
    }
}