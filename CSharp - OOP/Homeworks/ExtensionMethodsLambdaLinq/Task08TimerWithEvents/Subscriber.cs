using System.Threading;

public class Subscriber
{
    private int hour;
    private int minute;
    private int second;

    // the delegate the subscribers must implement
    public delegate void TimeChanger(object clock, TimeInfoEventArgs timeInformation);

    // an instance of the delegate
    public TimeChanger TimeChangeg;

    // set the clock running
    // it will raise an event for each new second
    public void Run(int delay)
    {
        while (true)
        {
            System.DateTime dt = System.DateTime.Now;    // Get the current time

            // create the TimeInfoEventArgs object
            // to pass to the subscriber
            TimeInfoEventArgs timeInformation = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);

            // if anyone has subscribed, notify them
            if (TimeChangeg != null)
            {
                TimeChangeg(this, timeInformation);
            }
            
            Thread.Sleep(delay*1000); // Sleep the program

            // update the state
            this.second = dt.Second;
            this.minute = dt.Minute;
            this.hour = dt.Hour;
        }
    }
}