using System;
using System.Collections.Generic;
using System.Linq;

//  We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
// Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, definethe class hierarchy and create a class diagram with Visual Studio.


class SchoolDemo
{
    static void Main()
    {
        // This is how I understand this task. On my opinion we must have school then class, teachers and students.
        // So first I make school after that few classes and put the into the school. After that few students and teachers and
        // put them into the specific class. And then comments disciplines and so on... So... I use methods to add students, 
        // teachers e.c. NOT through constructors. Because I must have first Scholl and classes then to put students and 
        // teachers into them. This is like "which is first? The egg or chicken?" So when made class we don't know
        // how many students we will have and we don't know their names either. This could be done with more construcotrs
        // but if we fire teacher or student we must create new reference of the object so its stupid and better way ismethods.  
        // well lets go through the program :). 
        School hogwarts = new School("Hogwarts"); // Create a school

        // Create few classes
        Class gryffindor = new Class("Gryffindor"); 
        Class slytherin = new Class("Slytherin");

        // Add each class to the school
        hogwarts.AddClass(gryffindor);
        hogwarts.AddClass(slytherin);

        // Create few students
        Student zPotter = new Student("Zaharry", "Potter", 1);
        Student hGranger = new Student("Hermione", "Granger", 2);
        Student dMalfoy = new Student("Draco", "Malfoy", 2);

        // Add each student to it class
        gryffindor.AddStundet(zPotter);
        gryffindor.AddStundet(hGranger);
        slytherin.AddStundet(dMalfoy);

        // Create few disciplines
        Discipline witchcraft = new Discipline("Witchcraft", 3, 4);
        Discipline quidditch = new Discipline("Quidditch", 1, 10);

        // Few teachers with their disciplines
        Teacher aDumb = new Teacher("Albus", "Dumbledore", new List<Discipline> { witchcraft, quidditch });
        Teacher rHagrid = new Teacher("Rubeus", "Hagrid", new List<Discipline> { quidditch });
        Teacher sSnape = new Teacher("Severus", "Snape", new List<Discipline> { witchcraft });

        // Add each teacher to it class
        gryffindor.AddTeacher(aDumb);
        gryffindor.AddTeacher(rHagrid);
        slytherin.AddTeacher(sSnape);

        // Few comments
        zPotter.AddComment("the chosen one!");
        hGranger.AddComment("hot chick!!!");
        zPotter.AddComment("quidditch master.");
        aDumb.AddComment("Why Dumbledore died?!?");
        sSnape.AddComment("\"S\" like a snake!");
        witchcraft.AddComment("One true wizard must know it");
        quidditch.AddComment("Funniest game ever");
        quidditch.AddComment("Zaharry Potter is the best on it!");
        gryffindor.AddComment("Best wizards ever!");
        slytherin.AddComment("Black magic > all.");
        gryffindor.AddComment("Zaharry I Love you!!!\nBy Hermione");

        // Printing all the sutffs
        var allStudents = gryffindor.GetStudents.Concat(slytherin.GetStudents);
        Console.WriteLine("Students and their comments:");
        foreach (var stud in allStudents)
        {
            Console.WriteLine(String.Format("{0} {1}", stud.FirstName, stud.Lastname));
            foreach (var item in stud.GetComments)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        var allTeachers = gryffindor.GetTeachers.Concat(slytherin.GetTeachers);
        Console.WriteLine("Teachers and their comments:");
        foreach (var teacher in allTeachers)
        {
            Console.WriteLine(String.Format("{0} {1}", teacher.FirstName, teacher.Lastname));
            foreach (var item in teacher.GetComments)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Teachers and their disciplines:");
        foreach (var teacher in allTeachers)
        {
            Console.WriteLine(String.Format("{0} {1}", teacher.FirstName, teacher.Lastname));
            foreach (var disciplines in teacher.Disciplines)
            {
                Console.WriteLine(disciplines.Name);
                Console.WriteLine(disciplines.Lectures);
                Console.WriteLine(disciplines.Exercises);
            }
        }

        Console.WriteLine("Disciplines and their comments:");
        foreach (var discipline in new List<Discipline> { witchcraft, quidditch })
        {
            Console.WriteLine(discipline.Name);
            foreach (var comment in discipline.GetComments)
            {
                Console.WriteLine(comment);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Classes and their comments:");
        foreach (var singleClass in new List<Class> { gryffindor, slytherin })
        {
            Console.WriteLine(singleClass.TextId);
            foreach (var comment in singleClass.GetComments)
            {
                Console.WriteLine(comment);
            }
            Console.WriteLine();
        }
    }
}