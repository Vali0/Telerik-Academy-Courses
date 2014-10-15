using System;

//Write a program that parses an URL address given in the format:
//		and extracts from it the [protocol], [server] and [resource] elements. 
//      For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//		[protocol] = "http"
//		[server] = "www.devbg.org"
//		[resource] = "/forum/index.php"


class Task12URLParts
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your url: ");
        string url = Console.ReadLine();

        int index, endIndex;

        index = url.IndexOf("://"); // Get the index of ://
        Console.WriteLine("[protocol] = \"{0}\"", url.Substring(0, index)); // This is the protocol

        index += 3;  // Placing the index after last slash of ://
        endIndex = url.IndexOf('/', index); // Index of next /
        Console.WriteLine("[server] = \"{0}\"", url.Substring(index, endIndex-index)); // This is the server

        Console.WriteLine("[resource] = \"{0}\"",url.Substring(endIndex).Trim()); // And the rest is the resource
    }
}