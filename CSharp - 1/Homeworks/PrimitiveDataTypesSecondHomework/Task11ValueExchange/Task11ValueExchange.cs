using System;

class Task11ValueExchange
{
    static void Main(string[] args)
    {
        // Declarating variables and initializing them
        int first = 5;
        int second = 10;
        Console.WriteLine("Before exchanging: {0} and {1}", first, second); // Printing values before exchanging
        //Exchanging values using third temporary variable
        int temp = first;
        first = second;
        second = temp;
        Console.WriteLine("After exchanging: {0} and {1}", first, second); // Printing values after exchanging
    }
}
