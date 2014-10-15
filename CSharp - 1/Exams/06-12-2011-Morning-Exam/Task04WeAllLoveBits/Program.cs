using System;

class Program
{
    static void Main(string[] args)
    {
        ushort n = ushort.Parse(Console.ReadLine());
        int number, mask, numberAndMask;
        byte bit = 2;

        int firstMagicP, secondMagicP;
        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            secondMagicP = 0;
            int[] array = new int[Convert.ToString(number, 2).Length];
            firstMagicP = number;
            for (int j = 0; j < Convert.ToString(number, 2).Length; j++)
            {
                mask = (1 << j);
                numberAndMask = number & mask;
                bit = (byte)(numberAndMask >> j);
                array[Convert.ToString(number, 2).Length - j -1 ] = bit;
                if (bit == 1)
                {
                    mask = ~(1 << j);
                    firstMagicP = firstMagicP & mask;
                }
                else
                {
                    mask = 1 << j;
                    firstMagicP = firstMagicP | mask;
                }
            }
            for (int k = 0; k < array.Length; k++)
            {
                secondMagicP += array[k] * (int)Math.Pow(2, k);
            }
            Console.WriteLine((number ^ firstMagicP) & secondMagicP);
        }
    }
}