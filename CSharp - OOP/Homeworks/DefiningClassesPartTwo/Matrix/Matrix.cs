using System;
using System.Text;

class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T> 
{
    // Fields
    private readonly T[,] matrix;

    // Constructor
    public Matrix(int row, int col)
    {
        this.matrix = new T[row, col];
    }

    // Properties
    public int Rows
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

    // Operator overrider
    public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
    {
        if ((first.Rows != second.Cols) || (first.Rows != second.Cols))
        {
            throw new FormatException("Adding (+) can't be used on matrixes with diferent dimensions");
        }

        Matrix<T> result = new Matrix<T>(first.Rows, second.Cols); // Object from the class to save the new matrix
        for (int i = 0; i < first.Rows; i++)
        {
            for (int j = 0; j < first.Cols; j++)
            {
                result[i, j] = (dynamic)first[i, j] + (dynamic)second[i, j]; // Simple summing of the elements
            }
        }
        return result;
    }

    public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
    {
        if ((first.Rows != second.Cols) || (first.Rows != second.Cols))
        {
            throw new FormatException("Substracting (-) can't be used on matrixes with diferent dimensions");
        }
        Matrix<T> result = new Matrix<T>(first.Rows, second.Cols); // Object from the class to save the new matrix
        for (int i = 0; i < first.Rows; i++)
        {
            for (int j = 0; j < first.Cols; j++)
            {
                result[i, j] = (dynamic)first[i, j] - (dynamic)second[i, j]; // Simple substract
            }
        }
        return result;
    }

    public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
    {
        if (first.Cols != second.Rows)
        {
            throw new FormatException("Multiplying can be used on matrixes with dimensions");
        }

        Matrix<T> result = new Matrix<T>(first.Rows, first.Cols); // Object from the class to save the new matrix
        for (int i = 0; i < first.Rows; i++)
        {
            for (int j = 0; j < first.Cols; j++)
            {
                for (int k = 0; k < first.Cols; k++)
                {
                    result[i, j] += (dynamic)first[i, k] * (dynamic)second[k, j]; // Simple multiplying
                }
            }
        }
        return result;
    }

    // ToString() overriding
    public override string ToString() // Overriding ToString() method
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < this.Rows; i++)
        {
            for (int j = 0; j < this.Cols; j++)
            {
                result.Append(matrix[i, j]);
                if (j != this.Cols - 1)
                {
                    result.Append(" ");
                }
                else if (j == this.Cols - 1 && i != this.Rows - 1)
                {
                    result.AppendLine();
                }
            }
        }
        return result.ToString();
    }

    //Implement the true operator (check for non-zero elements).
    public static bool operator true(Matrix<T> matr)
    {
        if (matr == null || matr.Rows == 0 || matr.Cols == 0)
        {
            return false;
        }

        for (int row = 0; row < matr.Rows; row++)
        {
            for (int col = 0; col < matr.Cols; col++)
            {
                if (!matr[row, col].Equals(default(T)))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static bool operator false(Matrix<T> matr)
    {
        if (matr == null || matr.Rows == 0 || matr.Cols == 0)
        {
            return true;
        }

        for (int row = 0; row < matr.Rows; row++)
        {
            for (int col = 0; col < matr.Cols; col++)
            {
                if (!matr[row, col].Equals(default(T)))
                {
                    return false;
                }
            }
        }

        return true;
    }


    // indexator
    public T this[int row,int col]
    {
        get
        {
            if (row > matrix.GetLength(0) || col > matrix.GetLength(1) || row < 0 || col < 0)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            T result = matrix[row, col];
            return result;
        }
        set
        {
            if (row > matrix.GetLength(0) || col > matrix.GetLength(1) || row < 0 || col < 0)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            matrix[row, col] = value;
        }
    }
}