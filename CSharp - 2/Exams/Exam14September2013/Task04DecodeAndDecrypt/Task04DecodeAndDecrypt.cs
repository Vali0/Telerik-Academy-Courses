using System;
using System.Collections.Generic;
using System.Text;

class Task04DecodeAndDecrypt
{
    private static List<char> letters = new List<char>();

    static void Main(string[] args)
    {
        StringBuilder cyper = new StringBuilder();
        string input = Console.ReadLine();
        
        string msg = Encode(input);

        foreach (var item in letters)
        {
            cyper.Append(item);
        }
        
        string encoded = Encrypt(msg, cyper.ToString()); // Encoding the text
        Console.WriteLine(encoded);
        ////string decoded = Decode(encoded, cyper.ToString()); // Decoding the text using encoding method
        //Console.WriteLine(decoded);
        //Console.WriteLine("Encoded text is: " + encoded); 
        //Console.WriteLine("Decoded text is: " + decoded);
    }

    private static string Encode(string input)
    {
        int num = 0;
        int number = 0;
        List<int> digits = new List<int>();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (Int32.TryParse(input[i].ToString(), out num))
            {
                digits.Add(num);
            }
            else
            {
                if (digits.Count == 0)
                {
                    digits.Add(1);
                }

                number = ConvertListToInt(digits);
                digits.Clear();
                sb.Append(Decode(number, input[i]));
            }
        }
        int cp = ConvertListToInt(digits);
        string message = sb.ToString();
        for (int i = message.Length - cp; i < message.Length; i++)
        {
            letters.Add(message[i]);
        }
        
        return message.Substring(0, message.Length - cp);
    }

    private static string Decode(int number, char p)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < number; i++)
        {
            sb.Append(p);
        }
        return sb.ToString();
    }

    public static string Encrypt(string text, string key)
    {
        StringBuilder result = new StringBuilder(text.Length);

        if (text.Length >= key.Length)
        {
            for (int i = 0; i < text.Length; i++)
            {
                result.Append((char)(((text[i] - 'A') ^ (key[i % key.Length] - 'A')) + 65));
            }
        }
        else
        {
            char[] temp = text.ToCharArray();

            for (int i = 0; i < key.Length; i++)
            {
                temp[i % temp.Length] = ((char)(((temp[i % temp.Length] - 'A') ^ (key[i] - 'A')) + 65));
            }
            foreach (var item in temp)
            {
                result.Append(item);
            }
        }
        return result.ToString();
    }

    public static string Decode(string text, string key)
    {
        // Decoding is performed by Encode method
        return Encrypt(text, key); 
    }

    private static int ConvertListToInt(List<int> list)
    {
        StringBuilder result = new StringBuilder();
        foreach (var item in list)
        {
            result.Append(item);
        }
        return int.Parse(result.ToString());
    }
}