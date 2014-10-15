using System;

// *(Bonus) Read in MSDN about the keyword event in C# and how to publish events. 
//Re-implement the above using .NET events and following the best practices.


class Task08TimerWithEvents
{
    // More info at: http://msdn.microsoft.com/en-us/library/orm-9780596521066-01-17.aspx
    public static void Main()
    {
        // create a new clock
        Subscriber theClock = new Subscriber();

        // create the display and tell it to
        // subscribe to the clock just created
        DisplayClock dc = new DisplayClock();
        dc.Subscribe(theClock);

        System.Console.WriteLine("Enter delay time (in seconds): ");
        int delay = int.Parse(Console.ReadLine());
        // Get the clock started
        theClock.Run(delay);
    }
}