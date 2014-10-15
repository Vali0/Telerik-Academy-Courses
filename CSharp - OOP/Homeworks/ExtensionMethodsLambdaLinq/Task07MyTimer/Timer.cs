using System;
using System.Diagnostics;

class Timer
{
    public static void MyTimer(int miliSeconds)
    {
        Stopwatch watch = new Stopwatch(); // Using stopwatch to count the time
        watch.Start();
        while (true)
        {
            if (watch.ElapsedMilliseconds == miliSeconds * 1000) // *1000 because we enter seconds but Stopwatch work with miliseconds
            {
                Console.WriteLine("TEXT");
                watch.Restart(); // Restart the watcher
            }
        }
    }
}