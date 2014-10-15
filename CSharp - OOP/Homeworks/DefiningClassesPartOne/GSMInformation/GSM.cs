using System;
using System.Collections.Generic;
using System.Text;

class GSM
{
    // Fields
    private string model, manufacturer, owner;
    private decimal? price;
    Battery battery; // Battery instance
    Display display; // Display instance
    private List<Call> callHistory = new List<Call>(); // List of Calls needed to save calls like history

    private static GSM iPhoene4S = new GSM("IPhone4S", "Apple",666m,"unknown",null); // static field of iPhone

    // Constructors
    public GSM(string model, string manufacturer, decimal? price, Battery battery) : this(model, manufacturer, price, null, battery, null)
    {
    }

    public GSM(string model, string manufacturer, string owner, Battery battery) : this(model, manufacturer, null, owner, battery, null)
    {
    }

    public GSM(string model, string manufacturer, Battery battery) : this(model, manufacturer, null, null, battery, null)
    {
    }

    public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery) : this(model,manufacturer,price,owner,battery,null)
    {
    }

    public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
    {
        // Using properties for encapsulation
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;
        this.battery = battery;
        this.display = display;
    }
    
    // Properties
    public List<Call> CallHistory
    {
        get
        {
            return this.callHistory;
        }
        set
        {
            this.callHistory = value;
        }
    }

    public decimal? Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value == null || value >= 0)
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            if (value == null || value.Length >= 0)
            {
                this.owner = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public string Manufacturer
    {
        get
        {
            return manufacturer;
        }
        set
        {
            if (value.Length >= 0)
            {
                this.manufacturer = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value.Length >= 0)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public static GSM IPhone4S
    {
        get
        {
            return iPhoene4S;
        }
    }

    // Methods
    public void AddCall(DateTime dt, string dailedNumber, ulong duration)
    {
        Call newCall = new Call(dt, dailedNumber, duration); // Creating new instance of Call
        CallHistory.Add(newCall); // Adding this object into the list using Property
    }

    public void DeleteCall(Call selectedCall)
    {
        CallHistory.Remove(selectedCall); // Deleting specific Call parsed by its instance
    }

    public void ClearHistory()
    {
        CallHistory.Clear(); // Clearing all history
    }

    public decimal CalculatePrice(decimal pricePerMinute)
    {
        decimal wholeTime = 0m;
        foreach (Call item in CallHistory)
        {
            wholeTime += item.Duration;    // Summing all durations
        }
        decimal price = 0m;
        price = pricePerMinute * (Math.Ceiling(wholeTime / 60)); // Calculating it
        return price;
    }

    // Simple method for printing the history in specific way
    public void DisplayHistory()
    {
        StringBuilder result = new StringBuilder();
        result.Append(new string('-',8));
        result.Append("Call history");
        result.AppendLine(new string('-', 7));
        foreach (Call item in CallHistory)
        {
            result.AppendFormat("Number: {0}, Date: {1}, Duration: {2} \n", item.DialedNumber, item.DateTime, item.Duration);
        }
        if (CallHistory.Count == 0)
        {
            result.AppendLine("Empty");
        }
        result.AppendLine(new string('-', 27));
       
        Console.Write(result);
    }

    // Ovveriding ToString() method for printing the information
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(new string('-', 12));
        result.Append("GSM");
        result.AppendLine(new string('-', 12));
        result.AppendLine(this.model);
        result.AppendLine(this.manufacturer);
        result.AppendLine(this.price.ToString());
        result.AppendLine(this.owner);
        result.Append(new string('-', 10));
        result.Append("Battery");
        result.AppendLine(new string('-', 10));
        result.AppendLine(battery.ToString());
        result.Append(new string('-', 10));
        result.Append("Display");
        result.AppendLine(new string('-', 10));

        if (display == null)
        {
            result.AppendLine("0");
            result.AppendLine("0");
        }
        else
        {
            result.AppendLine(display.ToString());
        }

        result.Append(new string('-', 27));
        return result.ToString();
    }
}