using System;

/*
* Write a program that creates an array containing all letters from the alphabet (A-Z).
* Read a word from the console and print the index of each of its letters in the array.
*/

class Task12WordIndexPositions
{
    static void Main(string[] args)
    {
        char[] letters = new char[26];
        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)('A' + i); // I'm Lazy :)
        }

        Console.WriteLine("Enter your word: ");
        char[] word = (Console.ReadLine().ToUpper().ToCharArray()); // Just in case to upper if YOU are lazy :)

        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine("Index of letter: " + word[i] + " is: " + (Array.BinarySearch(letters, word[i]) + 1));
        }
    }
}