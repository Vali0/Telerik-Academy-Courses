using System;
using System.Linq;

abstract class Animal : ISound
{
    // Fields
    private string name;
    private byte age;
    private char sex;

    // Constructors
    public Animal(string name, byte age, char sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
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
                throw new ArgumentNullException("Animal must have a name!");
            this.name = value;
        }
    }

    public byte Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Age of the animal can't be negative or zero!");
            this.age = value;
        }
    }

    public char Sex
    {
        get
        {
            return this.sex;
        }
        set
        {
            if (value != 'm' && value != 'f')
                throw new ArgumentNullException("Sex of the animal must be 'm' or 'f'");
            this.sex = value;
        }
    }

    // Methods
    public static double CalculateAge(Animal[] animals)
    {
        return animals.Average(ages => ages.Age); // Calculate specific species average age using Linq extension and lambda
    }

    public abstract string MakeNoise(); // Using polymorphism

    // Simple overriding of ToString()
    public override string ToString()
    {
        return String.Format("Breed: {0}, name: {1}, age: {2}, sex: {3}.\n{4}", 
            GetType(), Name, Age, Sex, MakeNoise());
    }
}