using System;
using System.Linq;

class AppDemo
{
    static void Main(string[] args)
    {
        // Define few animals
        Dog sharo = new Dog("Sharo", 4, 'm');
        Dog mary = new Dog("Mary", 6, 'f');
        Frog oscar = new Frog("Oscar",130,'m');
        Kitten kitty = new Kitten("Kitty", 1);
        Tomcat tom = new Tomcat("Tom", 10);

        Animal[] animals = { sharo, mary, oscar, kitty, tom }; // Make array from Animals to print their names age and sex

        Console.WriteLine("In our zoo there are these animals with their specific noises: ");
        foreach (var item in animals)
        {
            Console.WriteLine(item.ToString());
        }

        Dog[] dogs = { sharo, mary }; // Creating array from one kind
        Console.WriteLine("\nDogs average age is: " + Animal.CalculateAge(dogs)); // Calculate their age using static method
    }
}