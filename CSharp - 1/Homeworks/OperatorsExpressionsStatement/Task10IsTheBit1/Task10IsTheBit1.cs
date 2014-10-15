using System;

class Task10IsTheBit1
{
    static void Main(string[] args)
    {
        int number, mask, numberAndMask, position, bit;
        Console.WriteLine("Enter number value: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary format is : " + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter which position you want to see: ");
        position = int.Parse(Console.ReadLine());
        mask = 1 << position;
        numberAndMask = number & mask;
        bit = numberAndMask >> position;
        Console.WriteLine(bit == 1);
    }
}

