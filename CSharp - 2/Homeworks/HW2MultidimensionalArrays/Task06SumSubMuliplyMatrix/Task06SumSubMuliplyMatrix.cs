using System;

/* *Write a class Matrix, to holds a matrix of integers. Overload the operators for adding,
* subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().*/

class Task06SumSubMuliplyMatrix
{
    static void Main(string[] args)
    {
        // Matrix must have equal dimensions!
        int rows, cols;
        Console.WriteLine("Enter rows for your matrix: ");
        rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter cols for your matrix: ");
        cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Initialize your first matrix");
        OverrideMatrixClass firstMatrix = new OverrideMatrixClass(rows, cols); // Creating object for first matrix from OverrrideMatrix class
        firstMatrix = OverrideMatrixClass.FillMatrix(firstMatrix); //Calling method to fill the matrix from the other class

        Console.WriteLine("Initialize your second matrix");
        OverrideMatrixClass secondMatrix = new OverrideMatrixClass(rows, cols); // Creating object for second matrix from OverrrideMatrix class
        secondMatrix = OverrideMatrixClass.FillMatrix(secondMatrix); //Calling method to fill the matrix from the other class

        OverrideMatrixClass sum = firstMatrix + secondMatrix; // Summing two matrix using overrided sum operator '+'
        Console.WriteLine("\nAfter summing matrix looks like that");
        Console.WriteLine(sum.ToString()); // Printing the result using overrided ToString() method

        OverrideMatrixClass substract = firstMatrix - secondMatrix; // Substracting the matrixes using overrided substract operator '-'
        Console.WriteLine("After substracting matrix looks like that");
        Console.WriteLine(substract.ToString()); // Printing the result using overrided ToString() method

        OverrideMatrixClass product = firstMatrix * secondMatrix; // Multiplying the matrixes using overrided multiply operator '*'
        Console.WriteLine("After multiplying your matrix looks like that");
        Console.WriteLine(product.ToString()); // Printing the result using overrided ToString() method
    }
}