using System;
using System.Collections.Generic;

class Teacher : People
{
    // Fields
    private List<Discipline> disciplines;

    // Constructors
    public Teacher(string firstName, string lastName, List<Discipline> disciplines) : base(firstName, lastName)
    {
        this.disciplines = new List<Discipline>(disciplines);
    }
    
    // Properties
    public List<Discipline> Disciplines
    {
        get
        {
            return this.disciplines; // Get all disciplines
        }
    }
}