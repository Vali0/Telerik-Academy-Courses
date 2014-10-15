using System;

/*
1. Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
2. Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
3. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
*/

class StudentDemo
{
    static void Main(string[] args)
    {
        Student student = new Student("Pesho", "Ivanov", "Peshev", 0123, "Peshova mahala", 0987654321, "pesho@telerik.com", 3, Specialties.ComputerSystemsandTechnologies, Universities.TechnicalUniversity, Facutlies.ComputerSystemsandControl);

        Student student2 = new Student("Gosho", "Toshev", "Petrov", 123, "Sofia", 0123456789, "Gosho@abv.bg", 1, Specialties.Mechatronics, Universities.SofiaUniveristy, Facutlies.MechanicalEngineering);

        Student student3 = (Student)student.Clone(); // Cloning student1

        // Performing .Equals method and == operator to objects
        Console.WriteLine(student.Equals(student2));
        Console.WriteLine(student.Equals(student3));
        Console.WriteLine(student == student2);
        Console.WriteLine(student == student3);

        // Printing students
        Console.WriteLine("First student:");
        Console.WriteLine(student.ToString());
        Console.WriteLine("Cloned student:");
        Console.WriteLine(student3.ToString());
    }
}