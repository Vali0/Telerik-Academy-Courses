using System;
using System.IO;
using System.Text;

class ReadMatrix
{
    public int[,] ReadSquareMatrix()
    {
        int[,] array = null;
        try
        {
            StreamReader reader = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\squareMatrix.txt");
            StringBuilder result = new StringBuilder();
            
            using (reader)
            {
                int lineCounter = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    lineCounter++;
                    line = reader.ReadLine();
                }
                string matrix = result.ToString().Trim().Replace(" ", null); // Remove any white-spaceses
                array = new int[lineCounter, lineCounter];
                int p = 0;
                for (int i = 0; i < lineCounter; i++)
                {
                    for (int j = 0; j < lineCounter; j++)
                    {
                        array[i, j] = (matrix[p] - '0'); // Converting string matrix to matrix of ints
                        p++;
                    }
                }
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Can't find file.\n" + fnfe.Message);
        }
        return array;
    }
}