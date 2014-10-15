using System;

/*Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
* Write a program to test this method.*/

class Task01PrintingName
{
    static void Main(string[] args)
    {
        PrintName(); // Calling the method
    }

    static void PrintName()
    {
        string name;
        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Hello, " + name); // Printing the Hello, <name>
    }
}