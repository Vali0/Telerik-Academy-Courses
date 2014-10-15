using System;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all sentences containing given word.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.

class Task08PrintSpecificSentences
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your text: ");
        string text = Console.ReadLine(); // Read the text

        Console.WriteLine("Enter your word: ");
        string word = Console.ReadLine(); // Read the word

        int index = text.IndexOf('.'); // Get the index of '.' The task says only '.'
        int oldIndex = 0;

        // While loop for searching all '.' symbols in the text 
        while (index != -1)
        {
            string sentence = text.Substring(oldIndex, index - oldIndex + 1); // Get the sentence

            if (Regex.IsMatch(sentence, @"\b" + word + @"\b")) // If the sentence contains the word
            {
                Console.WriteLine(sentence); // Print the sentence
            }
            
            oldIndex = index + 2; // +2 because dot and interval
            index = text.IndexOf('.', index + 1);
        }
    }
}