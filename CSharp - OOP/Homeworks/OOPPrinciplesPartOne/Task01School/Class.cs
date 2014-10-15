using System;
using System.Collections.Generic;

class Class : Comment
{
    // Fields
    private string textId;
    private List<Student> students = new List<Student>();
    private List<Teacher> teachers = new List<Teacher>();

    // Properties
    public string TextId
    {
        get
        {
            return this.textId;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException("Class name can't be null");
            this.textId = value;
        }
    }

    public List<Teacher> GetTeachers
    {
        get
        {
            return this.teachers;
        }
    }

    public List<Student> GetStudents
    {
        get
        {
            return this.students;
        }
    }

    // Constructors
    public Class(string textId)
    {
        this.TextId = textId;
        // If you can tell me why work without following lines I will be very appreciated :)
        //this.students = new List<Student>();
        //this.teachers = new List<Teacher>();
    }

    // Methods
    public void AddStundet(Student stud)
    {
        this.students.Add(stud);
    }

    public void AddTeacher(Teacher teach)
    {
        this.teachers.Add(teach);
    }

    public void RemoveStudent(Student stud)
    {
        this.students.Remove(stud);
    }

    public void RemoveTeacher(Teacher teach)
    {
        this.teachers.Remove(teach);
    }
}