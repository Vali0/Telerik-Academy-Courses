using System;

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

class Task02TenDifferentValues
{
    static void Main(string[] args)
    {
        Random rand = new Random(); // Random generator
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rand.Next(100, 201)); // Method return an random number in bounds [left;right-1] <=> [left,right)
        }
    }
}