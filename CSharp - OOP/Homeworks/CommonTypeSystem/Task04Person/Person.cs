using System;
using System.Text;

class Person
{
    // Fields
    private string name;
    private byte? age; // If the age is not specified

    // Constructors
    public Person(string name) : this(name, null)
    {
    }

    public Person(string name, byte? age)
    {
        this.Name = name;
        this.Age = age;
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
            this.name = value;
        }
    }

    public byte? Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }

    // overriding ToString() methods
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("Name: ");
        result.AppendLine(this.Name);
        result.Append("Age: ");
        // Check if the age is specified or not
        if (this.Age == null)
        {
            result.Append("Not specified!");
        }
        else
        {
            result.Append(this.Age);
        }
        return result.ToString();
    }
}