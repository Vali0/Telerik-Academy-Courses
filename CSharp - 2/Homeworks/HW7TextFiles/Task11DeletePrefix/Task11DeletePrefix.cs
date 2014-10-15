using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.

/*Example:
this is test889321aasd92 and onlytest921
but this test929309asd_ can't be more than test__
and sure it is great test99999999999912385
end of testaaaaaaaasdkkwq
*/

class Task11DeletePrefix
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader reader = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\deleteprefix.txt");
            StringBuilder result = new StringBuilder();
            using (reader)
            {
                string text = reader.ReadToEnd();
                result.Append(Regex.Replace(text, @"(\b)test([A-Za-z0-9_])*", "")); // Using regular expression
                // \b - provides that the word start with "test" after it we have expression for all characters, numbers and '_'
                // * - show that we will match zero or more elements
            }
            using (StreamWriter writer = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\deleteprefix.txt"))
            {
                writer.Write(result.ToString().Replace("  ", " ")); // After regular replace we have some double white spaceses and it's good to remove them
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Can't open the file.\n" + fnfe.Message);
        }
    }
}