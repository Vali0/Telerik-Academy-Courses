using System;
using System.Text;

//Implement an extension method Substring(int index, int length) for the class 
//StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.


class Task01ExtensionOfStringBuilder
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your word: ");
        string input = Console.ReadLine();
        StringBuilder word = new StringBuilder();
        word.Append(input); // Load the input into the StringBuilder
        
        Console.WriteLine("Enter start index (counting from zero): ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter length: ");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("The substring is: " + word.Substring(index, length)); // Perform the substring
    }
}