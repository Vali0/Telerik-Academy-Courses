using System;
using System.IO;
using System.Text;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
//Example:
//	Ivan			George
//	Peter		->	Ivan
//	Maria			Maria
//	George			Peter


class Task06SortNamesFromFile
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader reader = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\names.txt");
       
            using (reader)
            {
                string text = reader.ReadToEnd().Replace("\n",null); // Unification of text file
                string[] array = text.Split(); // Spliting it
                Array.Sort(array); // Sorting the text
                using (StreamWriter writer = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\sortedNames.txt"))
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        writer.WriteLine(array[i]); // Writing the result into another file
                    }
                }
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Can't open file.\n" + fnfe.Message);
        }
    }
}