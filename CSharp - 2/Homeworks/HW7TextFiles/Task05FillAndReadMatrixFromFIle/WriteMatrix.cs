using System;
using System.IO;
using System.Text;

class WriteMatrix
{
    public void WriteSquareMatrix(int size)
    {
        StringBuilder input = new StringBuilder();
        string line = null;
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter your {0} line contain exactly {1} elements separated by ' ': ", i + 1, size);
            line = Console.ReadLine();
            input.AppendLine(line);
        }
        using (StreamWriter writer = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\squareMatrix.txt"))
        {
            writer.Write(input.ToString());
        }
    }
}