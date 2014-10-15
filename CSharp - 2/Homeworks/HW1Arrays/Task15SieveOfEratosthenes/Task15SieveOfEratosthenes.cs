using System;
using System.Linq;

class Task15SieveOfEratosthenes
{
    /*Write a program that finds all prime numbers in the range [1...10 000 000]. 
    Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
    */
    static void Main(string[] args)
    {
        // Info here: http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
        // Algorithm here: http://codereview.stackexchange.com/questions/6115/sieve-of-eratosthenes-in-c-with-linq

        
        // P.S. There is very big amount of numbers so be patient. PROGRAM WORKS!

        
        int cur = 1, total = 10000000;
        var pc = Enumerable.Range(2, total).ToList();
        while (cur <= Math.Sqrt(total))
        {
            cur = pc.First(i => i > cur);
            pc.RemoveAll(i => i != cur && i % cur == 0);
        }

        Console.WriteLine(1); // Just printing the first prime number rest in the loop
        foreach (var item in pc)
        {
            Console.WriteLine(item);
        }
    }
}