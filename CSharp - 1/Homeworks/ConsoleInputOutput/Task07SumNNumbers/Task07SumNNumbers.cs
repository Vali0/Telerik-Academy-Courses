using System;

class Task07SumNNumbers
{
    static void Main(string[] args)
    {
        int number, sum;
        Console.WriteLine("Enter your number: ");
        number = int.Parse(Console.ReadLine());
        sum = 0; // Task is confusive, we can initialize sum with the number (sum = number) too

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Enter your next number: ");
            sum += int.Parse(Console.ReadLine()); // Adding to sum
        }
        Console.WriteLine("Sum of n({0}) numbers is: {1}", number, sum); // Printing the sum
    }
}
