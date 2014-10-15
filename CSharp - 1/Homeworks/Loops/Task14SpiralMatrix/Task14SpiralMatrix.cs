using System;

class Task14matrixMatrix
{
    static void Main(string[] args)
    {

        //Defining and initializing matrix size
        int size = 0;
        Console.WriteLine("Enter size of your matrix: ");
        size = int.Parse(Console.ReadLine());

        //Defining matrix with specific size
        int[,] matrix = new int[size, size];

        // Needed to fill the matrix
        string direction = "right";

        int row = 0;
        int col = 0;

        // I get the logic by that video: http://www.youtube.com/watch?v=UPiodKGLsS4
        for (int i = 1; i <= size * size; i++)
        {
            // Nested ifs for changing the direction
            if (direction == "right" && (col >= size || matrix[row, col] != 0))
            {
                col--;
                row++;
                direction = "down";
            }
            else if (direction == "down" && (row >= size || matrix[row, col] != 0))
            {
                row--;
                col--;
                direction = "left";
            }
            else if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                col++;
                row--;
                direction = "up";
            }
            else if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                row++;
                col++;
                direction = "right";
            }

            // Filling the matrix
            matrix[row, col] = i;
            if (direction == "right")
                col++;
            else if (direction == "down")
                row++;
            else if (direction == "left")
                col--;
            else if (direction == "up")
                row--;
        }

        // Printing matrix matrix
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }

    }
}