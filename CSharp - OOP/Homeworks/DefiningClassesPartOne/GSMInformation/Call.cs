using System;

class Call
{
    // Fields
    private DateTime dateTime;
    private string dialedNumber;
    private ulong duration;

    // Constructor
    public Call(DateTime dateTime, string dialedNumber, ulong duration)
    {
        // Using properties for encapsulation
        this.DateTime = dateTime;
        this.DialedNumber = dialedNumber;
        this.Duration = duration;
    }
    
    // Properties
    public DateTime DateTime
    {
        get
        {
            return this.dateTime;
        }
        set
        {
            this.dateTime = value;
        }
    }

    public string DialedNumber
    {
        get
        {
            return this.dialedNumber;
        }
        set
        {
            this.dialedNumber = value;
        }
    }

    public ulong Duration
    {
        get
        {
            return this.duration;
        }
        set
        {
            this.duration = value;
        }
    }
}