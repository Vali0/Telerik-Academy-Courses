using System;

class Discipline : Comment
{
    // Fields
    private string name;
    private int lectures, exercises;

    // Constructors
    public Discipline(string name, int lectures, int exercises)
    {
        this.Name = name;
        this.Lectures = lectures;
        this.Exercises = exercises;
    }

    // Properties
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException("Discipline must have name");
            this.name = value;
        }
    }

    public int Lectures
    {
        get
        {
            return this.lectures;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Lectures hours can't be negative or zero");
            this.lectures = value;
        }
    }

    public int Exercises
    {
        get
        {
            return this.exercises;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Exercises hours can't be negative or zero");
            this.exercises = value;
        }
    }
}