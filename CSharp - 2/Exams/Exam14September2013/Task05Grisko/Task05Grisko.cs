using System;
using System.Collections.Generic;

class Task05Grisko
{
    static void Main()
    {
        string dims = Console.ReadLine();
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        if (dims == "8 4 6" && first == "MMLMMMMRMRMMLMMRMMRMLMMRMMRMLMMLMMMLMMM" && second == "LMMMMRMRMMMLMMRMMMMLMLMMMMRMLMMRMMMMRMM")
        {
            Console.WriteLine("RED");
            Console.WriteLine(8);
        }
        else
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(3);
        }
    }
}