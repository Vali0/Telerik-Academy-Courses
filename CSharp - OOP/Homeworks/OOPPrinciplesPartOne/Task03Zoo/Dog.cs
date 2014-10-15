using System;

class Dog : Animal
{
    // Constructors
    public Dog(string name, byte age, char sex) : base(name, age, sex)
    {
    }

    // Methods
    public override string MakeNoise() // Implement intefrace
    {
        return String.Format("Dog {0} sayed: baw, baw!", Name);
    }
}