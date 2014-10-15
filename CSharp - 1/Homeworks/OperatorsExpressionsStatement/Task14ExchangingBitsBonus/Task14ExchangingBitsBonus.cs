using System;

class Task14ExchangingBitsBonus
{
    static void Main(string[] args)
    {
        //Declarating and initializing input data
        int firstSequence, secondSequence, numberOfBits, decimalNumber, result, mask;

        Console.WriteLine("Enter your number: ");
        decimalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Number in binary format before swapping: " + Convert.ToString(decimalNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter first sequence of bits: ");
        firstSequence = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second sequence of bits: ");
        secondSequence = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many bits will be swapped: ");
        numberOfBits = int.Parse(Console.ReadLine());

        // Declarating masks
        int rightMask, leftMask;

        // Declarating andMasks
        int rightAMask, leftAMask;

        // Declarating right and left bits
        int rightBit, leftBit;
        result = decimalNumber;

        for (int i = firstSequence; i < firstSequence + numberOfBits - 1; i++)
        {
            // Making masks
            rightMask = 1 << i;
            rightAMask = result & rightMask;
            leftMask = 1 << secondSequence;
            leftAMask = result & leftMask;

            // Getting bits
            rightBit = rightAMask >> i;
            leftBit = 1 >> secondSequence;

            if (rightBit == 1)
            {
                mask = 1 << secondSequence;
                secondSequence++;
                result = result | mask; // Moving right bit if it is '1'
                if (leftBit == 0)
                {
                    mask = ~(1 << i);
                    result = result & mask; // Moving left bit if it is '0'
                }
                else
                {
                    mask = 1 << i;
                    result = result | mask; // Moving left bit if it is '1'
                }
            }
            else
            {
                mask = ~(1 << secondSequence);
                result = result & mask; // Moving right bit if it is '0'
                secondSequence++;
                if (leftBit == 0)
                {
                    mask = ~(1 << i);
                    result = result & mask; // Moving left bit if it is '0'
                }
                else
                {
                    mask = 1 << i; // Moving left bit if it is '1'
                    result = result | mask;
                }
            }
        }
        Console.WriteLine("Your new number in decimal format is: " + result);
        Console.WriteLine("Number in binary format after swapping:  " + Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}