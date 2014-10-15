using System;

class Task13ExchangingBits
{
    static void Main(string[] args)
    {
        uint number, firstMask, secondMask, nAFirstMask, nASecondMask, changing, thirdMask, fourthMask, result;
        Console.WriteLine("Enter the number: ");
        number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Number in binary format: " + Convert.ToString(number, 2).PadLeft(32, '0'));
        firstMask = 7 << 3;
        secondMask = 7 << 24;
        nAFirstMask = number & firstMask;
        nASecondMask = number & secondMask;
        changing = (number & ~firstMask) & ~secondMask;
        thirdMask = (number >> 3) << 24;
        fourthMask = (number >> 24) << 3;
        result = (changing | thirdMask) | fourthMask;
        Console.WriteLine("Your new number in decimal format: " + result);
        Console.WriteLine("Number in binary format: " + Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
