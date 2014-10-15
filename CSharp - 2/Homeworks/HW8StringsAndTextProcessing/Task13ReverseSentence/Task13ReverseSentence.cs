using System;

//Write a program that reverses the words in given sentence.
//	Example: C# is not C++, not PHP and not Delphi! -> Delphi not and PHP, not C++ not is C#!.

class Task13ReverseSentence
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your text: ");
        string text = Console.ReadLine();
               
        string[] words = text.Split(new char[] { ' ', ',', '!', '?', '.', }, StringSplitOptions.RemoveEmptyEntries); // Split setencese by words
        string[] signs = text.Split(words, StringSplitOptions.RemoveEmptyEntries); // Split setence by signs
        Array.Reverse(words); // Reversing each word
        
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write(words[i] + signs[i]); // Printing the result word + sign
        }
    }
}