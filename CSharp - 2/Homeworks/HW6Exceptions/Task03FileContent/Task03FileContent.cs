using System;
using System.IO;

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

class Task03FileContent
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter full path of your file: ");
            string fullPath = Console.ReadLine();
            ReadFile(fullPath); // Call the method
        }
        catch (Exception e)
        {
            throw new ApplicationException("Smth really bad happen!", e);
        }
    }

    static void ReadFile(string fullPath)
    {
        try
        {
            TextReader reader = reader = new StreamReader(fullPath); // Oppening the file reader

            try
            {
                string line = reader.ReadLine(); // Reading first line

                while (line != null) // Reading each next line till we have
                {
                    Console.WriteLine(line); // Printing each line
                    line = reader.ReadLine(); // Getting the next line
                }
            }
            finally
            {
                reader.Close(); // Closing reader stream
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File on this path doesn't exist!");
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("No path is given!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Can't find that directory!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file path format!");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}