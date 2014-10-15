using System;
using System.IO;
using System.Text.RegularExpressions;

//Modify the solution of the previous problem to replace only whole words (not substrings).

class Task08ReplaceOnlyWords
{
    static void Main(string[] args)
    {
        try
        {
            // Read the file
            StreamReader reader = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\replaceSubString.txt");
            string replacedText = null;
            using (reader)
            {
                string fullText = reader.ReadToEnd();
                string pattern = @"\bstart\b";
                string replace = "finish";
                replacedText = Regex.Replace(fullText, pattern, replace);
            }
            // Write the result into the same file
            using (StreamWriter writer = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\replaceSubString.txt"))
            {
                writer.Write(replacedText);
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Can't open file.\n" + fnfe.Message);
        }
    }
}