using System;
using System.Text;

//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR
//(exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.

class Task07EncryptAndDecrypt
{
    static void Main(string[] args)
    {
        string text, key;
        Console.WriteLine("Enter your text: ");
        text = Console.ReadLine(); // Read the text

        Console.WriteLine("Enter your keyword: ");
        key = Console.ReadLine(); // Read the key word

        string encoded = Encode(text, key); // Encoding the text
        string decoded = Decode(encoded, key); // Decoding the text using encoding method

        // Printing those two methods
        Console.WriteLine("Encoded text is: " + encoded); 
        Console.WriteLine("Decoded text is: " + decoded);
    }

    public static string Encode(string text, string key)
    {
        StringBuilder result = new StringBuilder(text.Length);

        for (int i = 0; i < text.Length; i++)
        {
            result.Append((char)(text[i] ^ key[i % key.Length]));
        }
        return result.ToString();
    }

    public static string Decode(string text, string key)
    {
        // Decoding is performed by Encode method
        return Encode(text, key); 
    }
}