using System;

class Task8EscapingSequence
{
    static void Main(string[] args)
    {
        string first = @"The ""use"" of quotations causes difficulties"; // String with quotations
        Console.WriteLine("With quotations: " + first);
        string second = "The \"use\" of quotations causes difficulties"; // String with escaping
        Console.WriteLine("With escaping: " + second);
    }
}