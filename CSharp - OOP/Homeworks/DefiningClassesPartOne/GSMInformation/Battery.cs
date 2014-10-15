using System;
using System.Text;

public enum BatteryType
{
    LiIon,
    NiMH,
    NiCd
}

class Battery
{
    // Fields
    private string model;
    private int? hoursIdle, hoursTalk;
    private BatteryType batType;

    // Constructors
    public Battery(string model) : this(model,null,null,0)
    {
    }

    public Battery(string model, int? hoursIdle) : this(model,hoursIdle,null,0)
    {
    }
   
    public Battery(string model, int? hoursIdle, int? hoursTalk, BatteryType batType)
    {
        // Using properties for encapsulation
        this.Model = model;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
        this.batType = batType;
    }

    // Properties
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }

    public int? HoursIdle
    {
        get
        {
            return this.hoursIdle;
        }
        set
        {
            if (value >= 0 || value == null)
            {
                this.hoursIdle = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public int? HoursTalk
    {
        get
        {
            return this.hoursTalk;
        }
        set
        {
            if (value >= 0 || value == null)
            {
                this.hoursTalk = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    // Overriding ToString() method for this Class on specific way
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine(this.model);
        result.AppendLine(this.batType.ToString());
        result.AppendLine(this.hoursIdle.ToString());
        result.Append(this.hoursTalk.ToString());

        return result.ToString();
    }
}