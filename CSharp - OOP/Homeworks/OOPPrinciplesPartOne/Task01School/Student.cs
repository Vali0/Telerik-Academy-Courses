using System;

class Student : People
{
    // Fields
    private int numberInClass;

    // Constructors
    public Student(string firstName, string lastname, int numberInClass) : base(firstName, lastname)
    {
        this.NumberInClass = numberInClass;
    }

    // Properties
    public int NumberInClass
    {
        get
        {
            return this.numberInClass;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Student number can't be negative or zero");
            this.numberInClass = value;
        }
    }
}