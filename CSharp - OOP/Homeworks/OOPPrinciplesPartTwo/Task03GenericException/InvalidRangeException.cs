using System;

class InvalidRangeException<T> : ApplicationException
{
    // Fields
    private T start, end;
   
    // Constructors
    public InvalidRangeException(T start, T end) : this(null, start, end, null)
    {
    }

    public InvalidRangeException(string msg, T start, T end) : this(msg, start, end, null)
    { 
    }

    public InvalidRangeException(string msg, T start, T end, Exception innerEx) : base(msg, innerEx)
    {
        this.start = start;
        this.end = end;
    }

    // Properties. Needed to print bounds
    public T Start
    {
        get
        {
            return this.start;
        }
    }

    public T End
    {
        get
        {
            return this.end;
        }
    }
}