using System;
using System.Linq;

//Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in descending order. Merge the lists and sort them by first name and last name.

class AppDemo
{
    static void Main(string[] args)
    {
        // Initializing 10 students
        Student[] students =
        {
            new Student("James","Hetifield",2.23f),
            new Student("Ozzy","Osbourne",5.99f),
            new Student("Rob", "Halford",6.00f),
            new Student("David", "Coverdale",5.50f),
            new Student("Bruce", "Dickinson", 6.00f),
            new Student("Kai", "Hansen", 5.66f),
            new Student("Steven", "Tyler",4.23f),
            new Student("Phil", "Anselmo",3.33f),
            new Student("Richie", "Blackmore",4.00f),
            new Student("Mark", "Tornillo",3.99f)
        };

        // Sorting them using Linq
        var sortedStudents = from stud in students
                             orderby stud.Grade ascending
                             select new { stud.FirstName, stud.LastName, stud.Grade };

        Console.WriteLine("Students:");
        foreach (var item in sortedStudents)
        {
            Console.WriteLine(item);
        }

        // Initializing 10 workers
        Worker[] workers =
        {
            new Worker("Phil","Collins",600m,10),
            new Worker("Eric","Clapton",1000m,16),
            new Worker("Garry","Moore",333m,8),
            new Worker("Chris","Rea",425m,6),
            new Worker("Axl","Rose",324m,4),
            new Worker("Ozzy","Zbourne",999m,2),
            new Worker("Alice","Cooper",234m,10),
            new Worker("Eirc","Adams",200m,13),
            new Worker("Ian","Gillan",444m,9),
            new Worker("Ken","Hansley",500m,10)
        };

        // Sorting them using Linq
        var sortedWorkers = from work in workers
                            orderby work.MoneyPerHour() descending
                            select new { work.FirstName, work.LastName };
        
        Console.WriteLine("\nWorkers:");
        foreach (var item in sortedWorkers)
        {
            Console.WriteLine(item);
        }

        // Concatinating two lists using Linq extension Concat<>();
        var concatenated = students.Concat<Human>(workers);

        // Sorting them using Linq
        var sortedConcatenated = from names in concatenated
                                 orderby names.FirstName ascending, names.LastName ascending
                                 select new { names.FirstName, names.LastName };

        Console.WriteLine("\nTwo lists sorted by names:");
        foreach (var item in sortedConcatenated)
        {
            Console.WriteLine(item);
        }
    }
}