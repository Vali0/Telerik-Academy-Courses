using System;
using System.IO;

//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).

class Task07ReplaceSubString
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader reader = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\replaceSubString.txt");
            string fullText = null;
            using (reader)
            {
                fullText = reader.ReadToEnd();

                if (fullText.Contains("start")) // if countains the substring first
                {
                    fullText = fullText.Replace("start", "finish");
                }
            }

            // Writing it into the same file
            using (StreamWriter writer = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\replaceSubString.txt"))
            {
                writer.Write(fullText);
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Can't open file.\n" + fnfe.Message);
        }
    }
}