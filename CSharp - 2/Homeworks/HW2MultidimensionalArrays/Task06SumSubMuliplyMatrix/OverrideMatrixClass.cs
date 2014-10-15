using System;

class OverrideMatrixClass
{
    private int[,] matrix;

    public int Rows // Property for private matrix
    {
        get
        {
            return this.matrix.GetLength(0); // To get the first dimension of the matrix
        }
    }

    public int Cols
    {
        get
        {
            return this.matrix.GetLength(1); // to get the second dimension of the matrix
        }
    }

    public int this[int row, int col] // Indexer override
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    public OverrideMatrixClass(int rows, int cols) // Constructor. Need to put some dimensions of the matrix
    {
        this.matrix = new int[rows, cols];
    }

    public static OverrideMatrixClass operator +(OverrideMatrixClass first, OverrideMatrixClass second)
    {
        OverrideMatrixClass result = new OverrideMatrixClass(first.Rows, second.Cols); // Object from the class to save the new matrix
        for (int i = 0; i < first.Rows; i++)
        {
            for (int j = 0; j < first.Cols; j++)
            {
                result[i, j] = first[i, j] + second[i, j]; // Simple summing of the elements
            }
        }
        return result;
    }

    public static OverrideMatrixClass operator -(OverrideMatrixClass first, OverrideMatrixClass second)
    {
        OverrideMatrixClass result = new OverrideMatrixClass(first.Rows, second.Cols); // Object from the class to save the new matrix
        for (int i = 0; i < first.Rows; i++)
        {
            for (int j = 0; j < first.Cols; j++)
            {
                result[i, j] = first[i, j] - second[i, j]; // Simple substract
            }
        }
        return result;
    }

    public static OverrideMatrixClass operator *(OverrideMatrixClass first, OverrideMatrixClass second)
    {
        OverrideMatrixClass result = new OverrideMatrixClass(first.Rows, first.Cols); // Object from the class to save the new matrix
        for (int i = 0; i < first.Rows; i++)
        {
            for (int j = 0; j < first.Cols; j++)
            {
                for (int k = 0; k < first.Cols; k++)
                {
                    result[i, j] += first[i, k] * second[k, j]; // Simple multiplying
                }
            }
        }
        return result;
    }

    public override string ToString() // Overriding ToString() method
    {
        string result = null;
        for (int i = 0; i < this.Rows; i++)
        {
            for (int j = 0; j < this.Cols; j++)
            {
                result += matrix[i, j] + " ";
            }
            result += Environment.NewLine; // New line
        }
        return result;
    }

    public static OverrideMatrixClass FillMatrix(OverrideMatrixClass matrix) // Simple method to fill the matrix. Must return object from the class not int[,]
    {
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Cols; j++)
            {
                Console.Write("matrix[{0},{1}] = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine()); // Reading the console input
            }
        }
        return matrix;
    }
}