// A subscriber: DisplayClock subscribes to the
// clock's events. The job of DisplayClock is
// to display the current time

using System;

public class DisplayClock
{
    // given a clock, subscribe to
    // its SecondChangeHandler event
    public void Subscribe(Subscriber theClock)
    {
        theClock.TimeChangeg += new Subscriber.TimeChanger(TimeHasChanged);
    }

    // the method that implements the
    // delegated functionality
    public void TimeHasChanged(object theClock, TimeInfoEventArgs ti)
    {
        Console.WriteLine("Current Time: {0}:{1}:{2}", ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
    }
}