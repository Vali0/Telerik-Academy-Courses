using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

//Write a program that reads a list of words from a file words.txt and finds how many times each of the words is 
//contained in another file test.txt. The result should be written in the file result.txt and the words should be 
//sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods.

/*Example:
ti si tozi koito kogato tq
i toi doide v tozi svqt i ti
i toi i tovaEti si rqwdwqktoi
oburka li se veche ti??? ili vse oshte si tq?
a moje bi tq e to ili nie?
*/
class Task13WordOccurrence
{
    static void Main(string[] args)
    {
        try
        {
            // This task is same as the previous
            // again read the words from file
            StreamReader words = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\words.txt");
            List<string> listOfWords = new List<string>(); // Here we will save the words
            string text = null;

            using (words)
            {
                string line = words.ReadLine();

                while (line != null)
                {
                    listOfWords.Add(line); // Put each word in the list
                    line = words.ReadLine(); // Read the next line(each word is on the separate line)
                }
            }
            try
            {
                // Read the text that will count
                StreamReader fileToReplace = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\test.txt");
                List<int> occurrence = new List<int>(); // here we will count each word how many times occurre

                using (fileToReplace)
                {
                    text = fileToReplace.ReadToEnd();

                    for (int i = 0; i < listOfWords.Count; i++)
                    {
                        // Using Regex.Matches().Count to count the matches with integrated regular expression
                        occurrence.Add(Regex.Matches(text, @"\b" + listOfWords[i] + @"\b").Count);
                    }
                }

                using (StreamWriter writer = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\result.txt"))
                {
                    // Converting lists to arrays
                    string[] arrayOfWords = listOfWords.ToArray(); 
                    int[] arrayOfOccurence = occurrence.ToArray();
                    
                    Array.Sort(arrayOfOccurence, arrayOfWords); // Sorting the array arrayOfWords by parameter arrayOfOccourence
                    for (int i = 0; i < listOfWords.Count; i++)
                    {
                        writer.WriteLine(arrayOfWords[i] + " -> " + arrayOfOccurence[i]); // Put the sorted result into the file
                    }
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