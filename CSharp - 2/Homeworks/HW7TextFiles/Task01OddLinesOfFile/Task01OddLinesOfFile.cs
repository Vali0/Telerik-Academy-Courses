using System;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

class Task01OddLinesOfFile
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader sr = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\printOddLines.txt");
            using (sr)
            {
                string line = sr.ReadLine(); // Read line of file
                int row = 1; // rows

                while (line != null) // Read to the end
                {
                    if (row % 2 != 0)
                        Console.WriteLine(line);

                    line = sr.ReadLine();
                    row++; // Go to another row
                }
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Can't open file.\n" + fnfe.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}