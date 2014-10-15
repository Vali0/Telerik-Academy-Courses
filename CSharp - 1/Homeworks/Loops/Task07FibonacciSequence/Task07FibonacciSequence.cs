using System;
using System.Numerics;

class Task07FibonacciSequence
{
    static void Main(string[] args)
    {
        // Defining variables
        uint firstMember = 0u;
        uint secondMember = 1u;
        uint thirdMember = 0u;
        uint length = 0u;

        BigInteger sum = 0u; // BigInteger just for sure

        Console.WriteLine("Enter how many members will have the sequence: ");
        length = uint.Parse(Console.ReadLine());

        uint[] members = new uint[length]; // Defining array where I will keep the members
        members[0] = firstMember; // Remember first two members
        members[1] = secondMember;
        for (int i = 2; i < length; i++)
        {
            thirdMember = firstMember + secondMember;
            firstMember = secondMember;
            secondMember = thirdMember;
            members[i] = thirdMember;
        }
        foreach (var item in members)
            sum += item; // Summing the members
        Console.WriteLine("The sum of the sequence is: " + sum); // Printing the sum
    }
}