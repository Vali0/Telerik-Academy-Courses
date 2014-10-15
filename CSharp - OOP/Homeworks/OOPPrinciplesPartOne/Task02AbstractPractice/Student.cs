using System;

class Student : Human // Inherit human abstract class
{
    // Fields
    private float grade;

    // Constructors
    public Student(string firstName, string lastName, float grade) : base(firstName, lastName)
    {
        this.Grade = grade;
    }

    // Properties
    public float Grade
    {
        get
        {
            return this.grade;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Grade can't be negative or zero!");
            this.grade = value;
        }
    }
}