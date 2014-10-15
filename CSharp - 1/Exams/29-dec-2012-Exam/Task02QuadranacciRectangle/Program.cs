using System;

class Program
{
    static void Main(string[] args)
    {
        Int64 a = Int64.Parse(Console.ReadLine());
        Int64 b = Int64.Parse(Console.ReadLine());
        Int64 c = Int64.Parse(Console.ReadLine());
        Int64 d = Int64.Parse(Console.ReadLine());
        Int64 rows, columns;
        do
        {
            rows = Int64.Parse(Console.ReadLine());
        }
        while (rows < 1 || rows > 20);
        do
        {
            columns = Int64.Parse(Console.ReadLine());
        }
        while (columns < 4 || columns > 20);
        Int64 temp = 0;
        Int64 n = 4;

        if (n != columns)
            Console.Write(a + " " + b + " " + c + " " + d + " ");
        else
            Console.Write(a + " " + b + " " + c + " " + d);

        for (Int64 i = 0; i < rows; i++)
        {
            for (Int64 j = n; j < columns; j++)
            {
                temp = a + b + c + d;
                a = b;
                b = c;
                c = d;
                d = temp;
                if (j != columns-1)
                    Console.Write(temp + " ");
                else if (j == columns-1)
                    Console.Write(temp);
            }
            n = 0;
            Console.WriteLine();
        }
    }
}
