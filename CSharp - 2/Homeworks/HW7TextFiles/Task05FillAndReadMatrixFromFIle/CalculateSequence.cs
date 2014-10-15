using System;

class CalculateSequence
{
    public static int CalculatingSum(int[,] matrix, int row, int col)
    {
        int sum = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                sum += matrix[i + row, j + col];
            }
        }
        return sum;
    }
}