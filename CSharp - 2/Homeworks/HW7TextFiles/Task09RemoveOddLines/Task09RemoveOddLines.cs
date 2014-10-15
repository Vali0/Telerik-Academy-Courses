using System;
using System.IO;
using System.Text;

//Write a program that deletes from given text file all odd lines. The result should be in the same file

class Task09RemoveOddLines
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader reader = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\fileWithRemovedLines.txt");
            StringBuilder sb = new StringBuilder();
            using (reader)
            {
                string line = reader.ReadLine();
                int row = 1;

                while (line != null)
                {
                    if (row % 2 == 0)
                    {
                        sb.AppendLine(line); // Append to the builder only even lines
                    }
                    line = reader.ReadLine();
                    row++;
                }
            }
            using (StreamWriter writer = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\fileWithRemovedLines.txt"))
            {
                writer.WriteLine(sb.ToString().Trim()); // Trim empty white-spaceses and write into the same file
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Can't open the file.\n" + fnfe.Message);
        }
    }
}