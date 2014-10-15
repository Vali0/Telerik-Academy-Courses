using System;

class Tomcat : Cat
{
    // Constructors
    public Tomcat(string name, byte age) : base(name, age, 'm')
    {
    }

    // Methods
    public override string MakeNoise() // Implement intefrace
    {
        return String.Format("Tomcat {0} sayed: mrrrrrrrrrqw, mrrrrrrrrrqw!", Name);
    }
}