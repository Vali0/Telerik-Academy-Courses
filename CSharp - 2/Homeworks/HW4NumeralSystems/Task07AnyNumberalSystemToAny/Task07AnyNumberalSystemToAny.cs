using System;

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

class Task07AnyNumberalSystemToAny
{
    static void Main(string[] args)
    {
        try
        {
            byte toNumSystem, fromNumSystem;
            Console.WriteLine("Enter which numeral system is your number(2,8,10,16): ");
            fromNumSystem = byte.Parse(Console.ReadLine());  // Getting the inputed number system

            Console.WriteLine("Enter your number: ");
            string number = Console.ReadLine(); // Entering the number using string variable (because hexadecimal numeral system)

            Console.WriteLine("Enter numberal system into which you want to convert your number(2,8,10,16): ");
            toNumSystem = byte.Parse(Console.ReadLine()); // Getting the new numeral system

            // Converting by using ToInt32 method and ToString method
            Console.WriteLine("Your number {0} which is in {1} numberal system converted into {2} numeral system looks like that: {3}",
                number, fromNumSystem, toNumSystem, Convert.ToString(Convert.ToInt32(number, fromNumSystem), toNumSystem));
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Wrong base!");
        }
    }
}