using System;

class FindMaxSum
{
    // This is the same as Homework 2 Task 02. You can found more info about it on my github profile:
    //https://github.com/Vali0/Telerik-Homeworks-CSharp-2/blob/master/HW2MultidimensionalArrays/Task02MaxSumOfSubSquareMatrix/Task02MaxSumOfSubSquareMatrix.cs

    public int FindSquareSequence(int[,] matrix)
    {
        int oldSum = 0;
        int sum = 0;
        int maxRow = 0;
        int maxCol = 0;
        for (int i = 0; i <= matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - 2; j++)
            {
                oldSum = 0;
                oldSum = CalculateSequence.CalculatingSum(matrix, i, j);
                if (oldSum > sum)
                {
                    sum = oldSum;
                    maxRow = i;
                    maxCol = j;
                }
            }
        }
        Console.WriteLine("Max square matrix 2x2 is: ");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (j != 1)
                {
                    Console.Write(matrix[i + maxRow, j + maxCol] + " ");
                }
                else
                {
                    Console.WriteLine(matrix[i + maxRow, j + maxCol]);
                }
            }
        }
        return sum;
    }
}