using System;
using System.IO;

//Write a program that compares two text files line by line and prints the number of lines that are the same 
//and the number of lines that are different. Assume the files have equal number of lines.

class Task04CompareTwoFiles
{
    static void Main(string[] args)
    {
        try
        {
            // Open streams for reading the files
            StreamReader firstFile = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\first.txt");
            StreamReader secondFile = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\second.txt");
            using (firstFile)
            {
                using (secondFile)
                {
                    // Reading first lines of thwo files (lines are equal)
                    string firstFileLine = firstFile.ReadLine();
                    string secondFileLine = secondFile.ReadLine();

                    // Counters
                    int equalLines = 0;
                    int nonEqualLines = 0;

                    while (firstFileLine != null)
                    {
                        if (firstFileLine.Equals(secondFileLine))
                        {
                            equalLines++;
                        }
                        else
                        {
                            nonEqualLines++;
                        }

                        // Read next line of two files
                        firstFileLine = firstFile.ReadLine();
                        secondFileLine = secondFile.ReadLine();
                    }
                    Console.WriteLine("There is {0} equal lines and {1} not equal lines.", equalLines, nonEqualLines);
                }
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Can't find file!\n" + fnfe.Message);
        }
    }
}