using System;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]

class VersionAtribute : System.Attribute // inherit basic class
{
    // Fields
    private int major, minor;

    // Constructor
    public VersionAtribute(int major, int minor)
    {
        this.major = major;
        this.minor = minor;
    }

    // Properties
    public int Major
    {
        get
        {
            return this.major;
        }
        private set
        {
            this.major = value;
        }
    }

    public int Minor
    {
        get
        {
            return this.minor;
        }
        private set
        {
            this.minor = value;
        }
    }
}