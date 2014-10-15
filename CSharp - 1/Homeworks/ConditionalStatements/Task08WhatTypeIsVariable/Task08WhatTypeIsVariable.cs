using System;

class Task08WhatTypeIsVariable
{
    static void Main(string[] args)
    {
        
        byte userChoice = 0;
        Console.WriteLine("Enter '1' for int '2' for double '3' for string: ");
        userChoice = byte.Parse(Console.ReadLine()); // Getting user choice

        switch (userChoice)
        {
            case 1: try
                {
                    Console.WriteLine("Enter your integer number: ");
                    int intInput = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your integer number increased with '1' is: " + (intInput + 1));
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("This is not integer!");
                    break;
                }
            case 2: try
                {
                    Console.WriteLine("Enter your double number: ");
                    double doubleInput = double.Parse(Console.ReadLine());
                    Console.WriteLine("Your double number increased with '1' is: " + (doubleInput + 1));
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("You entered a string!");
                    break;
                }
            case 3: Console.WriteLine("Enter your string: ");
                string stringInput = Console.ReadLine();
                Console.WriteLine("Your string appended with '*' is: " + stringInput + '*');
                break;
            default: Console.WriteLine("Wrong input!"); // If the input is different than '1' '2' or '3'
                break;
        }
    }
}