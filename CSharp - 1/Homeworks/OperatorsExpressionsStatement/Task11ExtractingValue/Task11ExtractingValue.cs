using System;

class Task11ExtractingValue
{
    static void Main(string[] args)
    {
        int number, bitPosition, mask, numberAndMask, bit;
        Console.WriteLine("Enter the number: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary format is : " + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter the bit position you want to extracts: ");
        bitPosition = int.Parse(Console.ReadLine());
        mask = 1 << bitPosition;
        numberAndMask = number & mask;
        bit = numberAndMask >> bitPosition;
        Console.WriteLine("Bit at the possition '{0}' is: {1}", bitPosition, bit);
    }
}
