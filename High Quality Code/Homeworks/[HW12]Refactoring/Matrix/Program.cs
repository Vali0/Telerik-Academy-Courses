namespace Matrix
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int size = ReadMatrixSize(Matrix.MaxSize);

            Matrix matrix = new Matrix(size);

            matrix.Traverse();

            Console.WriteLine(matrix);
        }

        private static int ReadMatrixSize(int maxSize)
        {
            string input;
            int size;

            do
            {
                Console.WriteLine("Enter matrix size (0, {0}]):", maxSize);
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out size) || size < 1 || size > maxSize);

            return size;
        }
    }
}