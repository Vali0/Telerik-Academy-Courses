using System;

class Task7StringToObjectCasting
{
    static void Main(string[] args)
    {
        string hello = "Hello"; // Declarating string with value "Hello"
        string world = "World"; // Declarating string with value "World"
        object helloWorld = hello + " " + world; // Declarating object and concatinate the two strings above
        string concatinatedObject = (String)helloWorld; // Casting object value to string
        Console.WriteLine(concatinatedObject);
    }
}
