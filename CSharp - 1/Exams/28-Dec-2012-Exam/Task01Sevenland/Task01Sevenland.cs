using System;

class Task01Sevenland
{
    static void Main(string[] args)
    {
        int input = 0;
        input = int.Parse(Console.ReadLine());
        input++;
        if (input < 7)
        {
            Console.WriteLine(input);
            return;
        }
        else if (input > 7 && input < 10)
        {
            Console.WriteLine(input + 3);
            return;
        }

        if (input % 10 == 7 && input < 67)
        {
            Console.WriteLine(input + 3);
            return;
        }
        else if (input % 10 != 7 && input < 67)
        {
            Console.WriteLine(input);
            return;
        }
        else if(input %10 == 7 && input>67 && input < 100)
        {
            Console.WriteLine(input+30);
            return;
        }
        if ((((input % 100) / 10) + 1) == 7 && input % 10 == 7)
        {
            input = input + 33;
            if (input == 700)
            {
                Console.WriteLine(1000);
            }
            else
                Console.WriteLine(input);
        }
        else if ((((input % 100) / 10) + 1) != 7 && input % 10 == 7)
        {
            Console.WriteLine(input + 3);
            return;
        }
        else if (input % 10 != 7)
        {
            Console.WriteLine(input);
            return;
        }
    }
}