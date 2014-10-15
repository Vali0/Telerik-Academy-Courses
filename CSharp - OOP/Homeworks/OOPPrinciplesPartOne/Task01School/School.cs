using System;
using System.Collections.Generic;

class School
{
    // Fields
    private List<Class> classes = new List<Class>();
    private string name;

    // Constructors
    public School(string name)
    {
        this.name = name;
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
                throw new ArgumentNullException("School must have name.");
            this.name = value;
        }
    }

    // Methods
    public void AddClass(Class @class)
    {
        this.classes.Add(@class);
    }

    public void RemoveClass(Class @class)
    {
        this.classes.Remove(@class);
    }

    public List<Class> Classes
    {
        get
        {
            return this.classes;
        }
    }
}