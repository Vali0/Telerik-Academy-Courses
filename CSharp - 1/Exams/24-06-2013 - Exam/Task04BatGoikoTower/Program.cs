using System;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        for (int i = 0; i < input; i++)
        {
            Console.Write(new String('.', input - i - 1));
            Console.Write('/');
            if (i ==1 || i==3 || i==6 || i==10 || i ==15 || i ==21 || i==28 || i==36)
            {
                Console.Write(new String('-', 2 * i));
            }
            else
            {
                Console.Write(new String('.', 2 * i));
              
            }
            Console.Write('\\');
            Console.Write(new String('.', input - i - 1));
            Console.WriteLine();
        }
    }
}
