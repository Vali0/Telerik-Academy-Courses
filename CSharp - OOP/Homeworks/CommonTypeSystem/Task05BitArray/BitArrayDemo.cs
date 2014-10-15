using System;

/*
Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
*/

class BitArrayDemo
{
    static void Main(string[] args)
    {
        BitArray64 number = new BitArray64(1234UL);

        foreach (var item in number) // Performing foreach
        {
            Console.Write(item);
        }
        Console.WriteLine();
        Console.WriteLine(number[5]); // Test of indexator

        BitArray64 sameNumber = new BitArray64(1234UL);

        Console.WriteLine(number.Equals(sameNumber)); // Performing overrided methods Equals
        Console.WriteLine(number == sameNumber); // Performing overrided operator ==
    }
}