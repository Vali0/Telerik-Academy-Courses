using System;
using System.Numerics;

class SumClass
{
    private string sequence;

    public SumClass(string seq)
    {
        this.sequence = seq;
    }
    
    public BigInteger SplitSequence()
    {
        String[] splittedSequence = this.sequence.Split(' '); // Splitting sequence
        BigInteger[] sequence = new BigInteger[splittedSequence.Length];

        for (int i = 0; i < sequence.Length; i++)
        {
            sequence[i] = BigInteger.Parse(splittedSequence[i]); // Fill integer array with values from string sequence
        }
        
        BigInteger result = SumSequence(sequence); // Call the other method to sum the values

        return result; // Return the result to Main method
    }

    public BigInteger SumSequence(BigInteger[] sequence)
    {
        BigInteger sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i]; // Simple summing each value
        }
        return sum;
    }
}