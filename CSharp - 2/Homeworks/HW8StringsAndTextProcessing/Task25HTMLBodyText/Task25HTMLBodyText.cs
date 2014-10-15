using System;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

//Example: Put this into the html file on the desktop named text.html
//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skillful .NET software engineers.</p></body>
//</html>


class Task25HTMLBodyText
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/text.html");
            using (reader)
            {
                string line = string.Empty;
                MatchCollection matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");
                while ((line = reader.ReadLine()) != null)
                {
                    matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");

                    foreach (var word in matchProtocolAndSiteName)
                        Console.WriteLine(word);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}