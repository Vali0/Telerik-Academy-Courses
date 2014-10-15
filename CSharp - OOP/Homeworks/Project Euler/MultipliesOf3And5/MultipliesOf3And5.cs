using System;
using System.Collections.Generic;
using System.Linq;

class MultipliesOf3And5
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();

        for (int i = 1; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                nums.Add(i);
            }
        }

        Console.WriteLine(nums.Sum());
    }
}