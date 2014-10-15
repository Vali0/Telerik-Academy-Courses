using System;
using System.Text.RegularExpressions;

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

//Example: 
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. 
//Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

//Result:
//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. 
//Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

class Task15ReplaceHTMLTags
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your HTML text");
        string text = Console.ReadLine();

        // Replacing by using Regex
        text = Regex.Replace(text, "<a href=\"", "[URL=");
        text = Regex.Replace(text, "\">", "]");
        text = Regex.Replace(text, "</a>", "[/URL]");
        
        Console.WriteLine("After replacing your HTML looks like this: \n" + text);
    }
}