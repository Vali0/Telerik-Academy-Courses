using System;
using System.Linq;

/*  *Modify your last program and try to make it work for any number type, not just integer
* (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#). */

class Task15GenericMethods
{
    static void Main(string[] args)
    {
        Console.WriteLine("The minimal element of the sequence is: " + MinimalElement(1, 0.2, 3298329845379));
        Console.WriteLine("The maximal element of the sequence is: " + MaximalElement(1, 2.2, 3.99999999999999, -3.9999999999, -0.0, 0.1));
        Console.WriteLine("The average of the sequence is: " + AverageSum(1, 2.22222222, 3));
        Console.WriteLine("The product of the sequence is: " + Product(-1, 2, 3237819, 4.2222332, 8));
    }

    // Little information about generic methods: http://msdn.microsoft.com/en-us/library/twcad0zb%28v=vs.80%29.aspx
    // Same task as the previous. With little difference of method type.
    static K MinimalElement<K>(params K[] input)
    {
        return input.Min<K>(); // Linq
    }

    static K MaximalElement<K>(params K[] input)
    {
        return input.Max<K>(); // Linq
    }

    // OK here I don't know why can't use Linq too. If you know why and how to implement it please write it on comment. Thanks
    static K AverageSum<K>(params K[] input)
    {
        dynamic sum = 0; // Must be dynamic because I don't know what type is the value which is given
        for (int i = 0; i < input.Length; i++)
        {
            sum += input[i];
        }
        return sum / input.Length; // Return the average
    }

    // Product is same as the previous task
    static K Product<K>(params K[] input)
    {
        dynamic result = 1; // Dynamic because ... ah... look few rows up :)
        for (int i = 0; i < input.Length; i++)
        {
            result *= input[i];
        }
        return result;
    }
}