using System;
using System.Text;

class Task12ASCIITable
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; // Eoncoding for all symbols
        //Loop starts here
        for (int i = 0; i < 127; i++)
        {
            Console.WriteLine("Character: {0} = {1}", i, (char)i); // Printing character using type casting
        }
        //Loop ends here
    }
}
