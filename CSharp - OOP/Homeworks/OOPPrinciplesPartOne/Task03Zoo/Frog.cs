using System;

class Frog : Animal
{
    // Constructors
    public Frog(string name, byte age, char sex) : base(name, age, sex)
    {
    }

    // Methods
    public override string MakeNoise() // Implement intefrace
    {
        return String.Format("Frog {0} sayed: krqk, krqk!", Name);
    }
}