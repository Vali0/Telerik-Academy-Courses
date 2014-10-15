using System;

class Kitten : Cat
{
    // Constructors
    public Kitten(string name, byte age) : base(name, age, 'f')
    {
    }

    // Methods
    public override string MakeNoise() // Implement intefrace
    {
        return String.Format("Kitten {0} sayed: mhew, mhew!", Name);
    }
}