using System;

/*
Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() todisplay the information of a person and if age is not specified – to say so. Write a program to test this functionality.
*/

class PersonDemo
{
    static void Main(string[] args)
    {
        Person person = new Person("Pesho"); // Create person with null age
        Console.WriteLine(person.ToString()); // Print information with null age
        person.Age = 10; // Set age on pesho
        Console.WriteLine(person.ToString()); // Print Pesho information with new age
    }
}