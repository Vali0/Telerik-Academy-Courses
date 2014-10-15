using System;
using System.IO;
using System.Text;

//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

class Task03InsertLineNumbers
{
    static void Main(string[] args)
    {
        try
        {
            // Read stream
            StreamReader readFile = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\concatenated.txt");

            using (readFile)
            {
                StringBuilder result = new StringBuilder();
                string line = readFile.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    result.Append(lineNumber); // Appending the line number
                    result.Append(' ', 2); // White-space to be user friendly
                    result.AppendLine(line); // Appending th text
                    line = readFile.ReadLine(); // Reading next line of file
                    lineNumber++; // Increasing row counter
                }

                // Writing the result into another file
                using (StreamWriter writer = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\fileWithLines.txt"))
                {
                    writer.WriteLine(result.ToString());
                }
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Can't find file!\n" + fnfe.Message);
        }
    }
}