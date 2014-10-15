using System;

// Create a [Version] attribute that can be applied to structures, classes, interfaces, 
// enumerations and methods and holds a version in the format major.minor (e.g. 2.11). 
// Apply the version attribute to a sample class and display its version at runtime.

// Set versions
[VersionAtribute(2, 2)]
[VersionAtribute(2, 3)]
class AtributeDemo
{
    static void Main(string[] args)
    {
        // Get from presentation
        Type type = typeof(AtributeDemo);
        object[] allVersions = type.GetCustomAttributes(false);

        foreach (VersionAtribute attr in allVersions)
        {
            Console.WriteLine("The version is: {0}.{1}. ", attr.Major, attr.Minor);
        }
    }
}