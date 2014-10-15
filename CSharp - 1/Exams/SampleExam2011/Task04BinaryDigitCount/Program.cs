using System;

class Program
{
    static void Main(string[] args)
    {
        byte digit = byte.Parse(Console.ReadLine());
        short numbers = short.Parse(Console.ReadLine());
        uint num = 0u;
        uint mask, numAndMask;
        int sum = 0;
        byte bit = 99;
        for (int i = 0; i < numbers; i++)
        {
            sum = 0;
            num = uint.Parse(Console.ReadLine());
            for (int j = 0; j < Convert.ToString(num, 2).Length; j++)
            {
                mask = (uint)(1 << j);
                numAndMask = num & mask;
                bit = (byte)(numAndMask >> j);
                if(bit == digit)
                    sum++;
            }
            if(sum!=0)
            Console.WriteLine(sum);
        }
    }
}
