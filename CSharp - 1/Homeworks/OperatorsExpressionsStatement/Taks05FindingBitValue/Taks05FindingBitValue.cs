using System;

class Taks05FindingBitValue
{
    static void Main(string[] args)
    {
        int enteredNumber = 0;
        Console.WriteLine("Enter the number: ");
        enteredNumber = int.Parse(Console.ReadLine());
        int position = 3;
        int mask = 1 << position;
        int numberAndMask = enteredNumber & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine(bit);
    }
}
