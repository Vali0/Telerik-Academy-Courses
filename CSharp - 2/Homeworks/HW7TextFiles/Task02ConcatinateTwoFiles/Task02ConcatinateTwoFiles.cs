using System;
using System.IO;
using System.Text;

//Write a program that concatenates two text files into another text file.

class Task02ConcatinateTwoFiles
{
    static void Main(string[] args)
    {
        try
        {
            // Read first file
            StreamReader firstFile = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\first.txt");
            {
                using (firstFile)
                {
                    string firstContent = firstFile.ReadToEnd();

                    try
                    {
                        // Read second file
                        StreamReader secondFile = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\second.txt");
                        {
                            using (secondFile)
                            {
                                string secondContent = secondFile.ReadToEnd();

                                //Write into third file
                                using (StreamWriter concatenatedFile = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\concatenated.txt"))
                                {
                                    StringBuilder result = new StringBuilder(); // Need to concatinate two strings
                                    result.AppendLine(firstContent);
                                    result.AppendLine(secondContent);
                                    concatenatedFile.Write(result.ToString());
                                }
                            }
                        }
                    }
                    catch (FileNotFoundException fnfe)
                    {
                        Console.WriteLine("Can't find second file\n" + fnfe.Message);
                    }
                }
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Can't find first file\n" + fnfe.Message);
        }
    }
}