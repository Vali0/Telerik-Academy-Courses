using System;

//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix
//an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size
//of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single number
//in a separate text file.

class Task05FillAndReadMatrixFromFIle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of your square matrix: ");
        int size = int.Parse(Console.ReadLine());
        
        WriteMatrix wm = new WriteMatrix();
        wm.WriteSquareMatrix(size); // Write the matrix
        
        ReadMatrix rm = new ReadMatrix();
        int[,] matrix = rm.ReadSquareMatrix(); // Read the matrix from file

        FindMaxSum fms = new FindMaxSum();
        int sum = fms.FindSquareSequence(matrix); // Find the 2x2 matrix

        Console.WriteLine("With sum: " + sum); // Print the result
    }
}