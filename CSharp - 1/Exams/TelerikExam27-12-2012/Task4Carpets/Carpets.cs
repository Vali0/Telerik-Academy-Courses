using System;

class Carpets
{
    static void Main(string[] args)
    {
        int counter1, counter2;
        counter1 = 1;
        counter2 = 1;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', n / 2 - i - 1));
            Console.Write('/');
            if (i == 0)
                Console.Write('\\');
            else if (i % 2 != 0)
            {
                Console.Write("  ");
                Console.Write('\\');
            }

            
            Console.WriteLine(new string('.', n / 2 - i - 1));
        }
    }
}
