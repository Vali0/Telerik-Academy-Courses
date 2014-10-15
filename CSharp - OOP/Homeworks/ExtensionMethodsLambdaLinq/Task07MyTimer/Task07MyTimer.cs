using System;

//Using delegates write a class Timer that has can execute certain method at each t seconds.

public delegate void TimerDelegate(int miliSeconds);

class Task07MyTimer
{
    static void Main(string[] args)
    {
        TimerDelegate timer = new TimerDelegate(Timer.MyTimer); // Call the delegate

        Console.Write("Enter time in secods: ");
        int seconds = int.Parse(Console.ReadLine());

        timer(seconds); // Invoke delegate
    }
}