using System;
using System.Text;
using System.IO;

//Write a program that extracts from given XML file all the text without the tags. 

class Task10ExtractTextFromXML
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader reader = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\xml tags.txt");
            StringBuilder result = new StringBuilder();
            using (reader)
            {
                char particle;
                Boolean flag = false;
                while (!reader.EndOfStream)
                {
                    particle = (char)reader.Read();
                    if (particle != '\n') // Remove new lines from file
                    {
                        if (particle == '<') // If we see open tag
                        {
                            while (particle != '>') // While we see closing tag miss all info
                            {
                                particle = (char)reader.Read();
                            }
                            flag = true; // Put the flag for new line
                        }
                        else
                        {
                            if (flag == true) // If the flag for new line is true we print the new line
                            {
                                result.Append(Environment.NewLine); // user friendly line 
                                flag = false; // put the flag back to false
                            }
                            result.Append(particle); // put the infor out of the tags
                        }
                    }
                }
            }
            Console.WriteLine(result.ToString().Trim()); // Trim the result just for sure
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Can't open the file.\n" + fnfe.Message);
        }
    }
}