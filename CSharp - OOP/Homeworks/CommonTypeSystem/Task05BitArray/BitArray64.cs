using System;
using System.Collections.Generic;

class BitArray64 : IEnumerable<int>
{
    // Fields
    private ulong number;

    // Constructors
    public BitArray64(ulong number)
    {
        this.Number = number;
    }

    // Properties
    public ulong Number
    {
        get
        {
            return this.number;
        }
        set
        {
            this.number = value;
        }
    }

    // Indexator
    public int this[int index]
    {
        get
        {
            // Check if the parsed index is in bounds
            if (index < 0 || index > 63)
            {
                throw new IndexOutOfRangeException("Index must be in range [0, 63].");
            }

            return (int)((this.number >> index) & 1);
        }
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 63; i >= 0; i--)
        {
            yield return this[i];
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    // Overriding Equals method
    public override bool Equals(object obj)
    {
        if (!(obj is BitArray64)) // Check if the parsed object is from BitArray64 class
        {
            return false;
        }
        BitArray64 bitArray = (BitArray64)obj; // Type casting it to class type

        if (!Object.Equals(this.Number, bitArray)) // And compare its value
        {
            return false;
        }
        
        return true;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int result = 17;
            result = result * 23 + this.number.GetHashCode();
            return result;
        }
    }

    // Pre-defining operators == and !=
    public static bool operator ==(BitArray64 firstBitArray, BitArray64 secondBitArray)
    {
        return BitArray64.Equals(firstBitArray, secondBitArray);
    }

    public static bool operator !=(BitArray64 firstBitArray, BitArray64 secondBitArray)
    {
        return !BitArray64.Equals(firstBitArray, secondBitArray);
    }
}