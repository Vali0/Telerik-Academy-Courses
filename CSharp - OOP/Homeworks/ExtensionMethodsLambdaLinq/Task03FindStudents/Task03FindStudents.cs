using System;
using System.Collections.Generic;
using System.Linq;

// 3. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.
// 4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
// 5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
//first name and last name in descending order. Rewrite the same with LINQ.

class Task03_04_05FindStudents
{
    static void Main(string[] args)
    {
        // First I write that task with generic list by mistake, so you can see the solution below.

        Console.WriteLine("Enter how many students will you have: ");
        int size = int.Parse(Console.ReadLine());

        Students[] students = new Students[size]; // Array of stundets 

        // Fill the array with data
        for (int i = 0; i < size; i++)
        {
            Students student = new Students();
            Console.Write("First name: ");
            student.FirstName = Console.ReadLine();
            Console.Write("Last name: ");
            student.LastName = Console.ReadLine();
            Console.Write("Age: ");
            student.Age = byte.Parse(Console.ReadLine());
            students[i] = student;
        }
        
        // And expressions starts here
        // Nothing strange so there won't be any comments. Maybe only select new { }; which extracts one or many fields from the array using properties
        var alphabeticallyFirst = from stud in students
                                  where stud.FirstName.CompareTo(stud.LastName) < 0
                                  select new { stud.FirstName, stud.LastName };

        Console.WriteLine("Students which first name is alphabetically before than last:");
        foreach (var item in alphabeticallyFirst)
        {
            Console.WriteLine(item);
        }
        
        var specificAge = from ages in students
                          where ages.Age >= 18 && ages.Age <= 24
                          select new { ages.FirstName, ages.LastName };

        Console.WriteLine("Students which age is between 18 and 24:");
        foreach (var item in specificAge)
        {
            Console.WriteLine(item);
        }

        var sortedLambda = students
                                   .OrderByDescending(first => first.FirstName)
                                   .ThenByDescending(second => second.LastName);
        
        Console.WriteLine("Sorted students with lambda:");
        foreach (var item in sortedLambda)
        {
            Console.WriteLine(item);
        }

        var sortedLinq = from names in students
                         orderby names.FirstName descending, names.LastName descending
                         select new { names.FirstName, names.LastName, names.Age };

        Console.WriteLine("Sorted students with Linq:");
        foreach (var item in sortedLinq)
        {
            Console.WriteLine(item);
        }

        // With generic list only must make sort to descending
        /*  List<Students> students = new List<Students>();
        for (int i = 0; i < size; i++)
        {
        Students student = new Students();
        Console.Write("First name: ");
        student.FirstName = Console.ReadLine();
        Console.Write("Last name: ");
        student.LastName = Console.ReadLine();
        Console.Write("Age: ");
        student.Age = byte.Parse(Console.ReadLine());
        students.Add(student);
        }
        var alphabeticallyFirst = students
        .Where(names => names.FirstName.CompareTo(names.LastName) < 0)
        .Select(names => new { names.FirstName, names.LastName });
        Console.WriteLine("Students which first name is alphabetically before than last:");
        foreach (var item in alphabeticallyFirst)
        {
        Console.WriteLine(item);
        }
        var specificAge = students
        .Where(age => age.Age >= 18 && age.Age <= 24)
        .Select(names => new { names.FirstName, names.LastName });
        Console.WriteLine("Students which age is between 18 and 24:");
        foreach (var item in specificAge)
        {
        Console.WriteLine(item);
        }
        students.Sort((first, last) =>
        {
        int result = first.FirstName.CompareTo(last.FirstName);
        return result != 0 ? result : first.LastName.CompareTo(last.LastName);
        });
        Console.WriteLine("Sorted students with lambda:");
        foreach (var item in students)
        {
        Console.WriteLine(item.ToString());
        }
        var sortedLinq = students
        .OrderBy(name => name.FirstName)
        .ThenBy(name => name.LastName)
        .ToList();
        Console.WriteLine("Sorted students with Linq:");
        foreach (var item in sortedLinq)
        {
        Console.WriteLine(item.ToString());
        }*/
    }
}