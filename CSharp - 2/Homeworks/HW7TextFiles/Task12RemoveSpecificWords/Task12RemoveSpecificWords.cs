using System;
using System.IO;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

/*Example:
ti si takuv kakuvto az sum
i ti ne si takuv kakuvto toi e
no az sum kato teb i ttoi
Kakva e tq i kjdqwkjtoi ?
*/

class Task12RemoveSpecificWords
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader words = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\words.txt");
            StringBuilder pattern = new StringBuilder();
            string text = null;

            using (words)
            {
                string line = words.ReadLine();
                
                while (line != null)
                {
                    pattern.Append(@"(\b)"); // Appending \b to provide that we will match the word at the beginning
                    pattern.Append(line); // Appending the word from file
                    pattern.Append(@"(\b)"); // Appening \b at the end to provide that we will match only the word from file
                    pattern.Append("|"); // | - or operator for other words
                    line = words.ReadLine(); // read the next line from file
                }
            }

            try
            {
                // reader to read the file which words we will replace
                StreamReader fileToReplace = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\textToReplace.txt");
           
                using (fileToReplace)
                {
                    text = fileToReplace.ReadToEnd(); // Reading the content from file
                    text = Regex.Replace(text, @pattern.ToString(), "").Replace("  ", " "); // Replacing the text with the pattern and removing double white spaceses
                }

                // Writing the result in the same file
                using (StreamWriter sw = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\textToReplace.txt"))
                {
                    sw.Write(text);
                }
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("Can't open the second file.\n" + fnfe.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine("Second file error.\n" + dnfe.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Second file error.\n" + ioe.Message);
            }
            catch (SecurityException se)
            {
                Console.WriteLine("Second file error.\n" + se.Message);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine("Second file error.\n" + uae.Message);
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Can't open the first file.\n" + fnfe.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine("First file error.\n" + dnfe.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine("First file error.\n" + ioe.Message);
        }
        catch (SecurityException se)
        {
            Console.WriteLine("First file error.\n" + se.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine("First file error.\n" + uae.Message);
        }
    }
}