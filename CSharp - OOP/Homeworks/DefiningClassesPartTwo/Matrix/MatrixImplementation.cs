using System;

// 8. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
// 9. Implement an indexer this[row, col] to access the inner matrix cells.
// 10. Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
// Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).

class MatrixImplementation
{
    static void Main(string[] args)
    {
        Matrix<int> firstMatrix = new Matrix<int>(2, 2);
        Matrix<int> secondMatrix = new Matrix<int>(2, 2);
        Matrix<int> wrongMatrix = new Matrix<int>(3, 3);

        for (int i = 0; i < firstMatrix.Rows; i++)
        {
            for (int j = 0; j < firstMatrix.Cols; j++)
            {
                firstMatrix[i, j] = 1;
                secondMatrix[i, j] = 2;
            }
        }
        Console.WriteLine("first matrix:");
        Console.WriteLine(firstMatrix.ToString());
        Console.WriteLine("second matrix:");
        Console.WriteLine(secondMatrix.ToString());

        dynamic sum = firstMatrix + secondMatrix;
        Console.WriteLine("After summing:\n" + sum);

        dynamic substract = firstMatrix - secondMatrix;
        Console.WriteLine("After substraction:\n" + substract);

        dynamic multiplication = firstMatrix * secondMatrix;
        Console.WriteLine("After multiplying:\n" + multiplication);
        //multiplication = firstMatrix * wrongMatrix; // Cause exception
    }
}