using System;
using System.Text;

class Display
{
    // Fields
    private float? size;
    private byte? numberColors;

    // Constructors
    public Display(float? size) : this(size, null)
    {
    }

    public Display(byte? numberColors) : this(null,numberColors)
    {
    }

    public Display(float? size, byte? numberColors)
    {
        // Using properties for encapsulation
        this.Size = size;
        this.NumberColors = numberColors;
    }

    // Properties
    public float? Size
    {
        get
        {
            return this.size;
        }
        set
        {
            if (value >= 0 || value == null)
            {
                this.size = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public byte? NumberColors
    {
        get
        {
            return this.numberColors;
        }
        set
        {
            if (value >= 0 || value == null)
            {
                this.numberColors = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    // Overriding ToString() method for this class
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine(this.size.ToString());
        result.Append(this.numberColors);
        return result.ToString();
    }
}