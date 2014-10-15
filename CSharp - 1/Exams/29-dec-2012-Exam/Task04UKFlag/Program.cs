using System;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        for (int i = 0; i < input/2; i++)
        {
            Console.Write(new string ('.',i));
            Console.Write('\\');
            Console.Write(new string('.', input/2-i-1));
            Console.Write('|');
            Console.Write(new string('.', input/2-i-1));
            Console.Write('/');
            Console.WriteLine(new string('.', i));
        }
        Console.WriteLine(new string('-',input/2) + '*' + new string('-',input/2));
        for (int i = input / 2; i > 0; i--)
        {
            Console.Write(new string ('.',i-1));
            Console.Write('/');
            Console.Write(new string('.',input/2-i));
            Console.Write('|');
            Console.Write(new string('.', input / 2 - i));
            Console.Write('\\');
            Console.WriteLine(new string ('.',i-1));
        }
    }
}