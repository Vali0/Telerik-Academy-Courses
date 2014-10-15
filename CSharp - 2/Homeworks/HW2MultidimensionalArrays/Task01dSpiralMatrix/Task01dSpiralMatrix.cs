using System;

// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

class Task01dSpiralMatrix
{
    static void Main(string[] args)
    {
        //Defining and initializing matrix size
        int size = 0;
        string direction = "down"; // Needed for directions.
        int element = 1;
        int row = 0;
        int col = 0;

        Console.WriteLine("Enter size of your matrix: ");
        size = int.Parse(Console.ReadLine());

        //Defining matrix with specified size
        int[,] matrix = new int[size, size];

        for (int i = 0; i < size * size; i++) // size*size the sum of the elements in the matrix
        {
            if (direction == "down")
            {
                while (row < size && matrix[row, col] == 0)
                {
                    matrix[row, col] = element++; // Filling the matrix with specific element. Same for the lines below.
                    row++;
                }
                col++; //To stay in bounds. Same for the lines below
                row--; //To stay in bounds. Same for the lines below
                direction = "right";  // Changing the direction
            }
            else if (direction == "right")
            {
                while (col < size && matrix[row, col] == 0)
                {
                    matrix[row, col] = element++;
                    col++;
                }
                col--;
                row--;
                direction = "up"; // Changing the direction
            }
            else if (direction == "up")
            {
                while (row >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col] = element++;
                    row--;
                }
                direction = "left";
                row++;
                col--;
            }
            else if (direction == "left") // Changing the direction
            {
                while (col >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col] = element++;
                    col--;
                }
                direction = "down"; // // Changing the direction. One cycle
                row++;
                col++;
            }
        }

        // Printing the matrix
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