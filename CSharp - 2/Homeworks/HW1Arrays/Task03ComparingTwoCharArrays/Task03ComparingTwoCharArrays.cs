using System;

class Task03ComparingTwoCharArrays
{
    //Write a program that compares two char arrays lexicographically (letter by letter).

    static void Main(string[] args)
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).
        Console.WriteLine("Enter size of the first array");
        char[] firstArray = new char[int.Parse(Console.ReadLine())];
        Console.WriteLine("Enter size of the second array");
        char[] secondArray = new char[int.Parse(Console.ReadLine())];
        if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine("First array is larger than second, so they aren't lexicographically equal");
            return;
        }
        else if (firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("Seocnd array is larger than first, so they aren't lexicographically equal");
            return;
        }
        else
        {
            Console.WriteLine("Initialize first char array");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("firstArray[{0}] = ",i);
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Initialize second char array");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("secondArray[{0}] = ",i);
                secondArray[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("Lexicographically the second array is first");
                    return;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("Lexicographically the first array is first");
                    return;
                }
            }
        }
        Console.WriteLine("Lexicographically the two arrays are equal");
    }
}