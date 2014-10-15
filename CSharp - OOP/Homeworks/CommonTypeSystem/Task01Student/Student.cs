using System;

class Student : ICloneable, IComparable<Student>
{
    
    // Fields
    private string firstName, middleName, lastName, address, email;
    private uint socialSecurity, mobilePhone;
    private byte course;
    Specialties speciality;
    Universities univeristy;
    Facutlies faculty;

    // Constructors
    public Student(string firstName, string middleName, string lastName, uint socialSecurity, string address, uint mobilePhone, string email, byte course, Specialties speciality, Universities univeristy, Facutlies faculty)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SocialSecurity = socialSecurity;
        this.Address = address;
        this.MobilePhone = mobilePhone;
        this.Email = email;
        this.Course = course;
        this.Speciality = speciality;
        this.Univeristy = univeristy;
        this.Faculty = faculty;
    }

    // Properties
    public Specialties Speciality
    {
        get
        {
            return this.speciality;
        }
        set
        {
            this.speciality = value;
        }
    }

    public Universities Univeristy
    {
        get
        {
            return this.univeristy;
        }
        set
        {
            this.univeristy = value;
        }
    }

    public Facutlies Faculty
    {
        get
        {
            return this.faculty;
        }
        set
        {
            this.faculty = value;
        }
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            this.firstName = value;
        }
    }

    public string MiddleName
    {
        get
        {
            return this.middleName;
        }
        set
        {
            this.middleName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            this.lastName = value;
        }
    }

    public uint SocialSecurity
    {
        get
        {
            return this.socialSecurity;
        }
        set
        {
            this.socialSecurity = value;
        }
    }

    public string Address
    {
        get
        {
            return this.address;
        }
        set
        {
            this.address = value;
        }
    }

    public uint MobilePhone
    {
        get
        {
            return this.mobilePhone;
        }
        set
        {
            this.mobilePhone = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            this.email = value;
        }
    }

    public byte Course
    {
        get
        {
            return this.course;
        }
        set
        {
            this.course = value;
        }
    }
    
    // Overriding Equals method. 
    public override bool Equals(object obj)
    {
        if (!(obj is Student)) // Check if the input is Student object or smth else
        {
            return false;
        }
        Student student = (Student)obj; // Type casting the object to Student

        // Comparing fields
        if (!Object.Equals(this.FirstName, student.FirstName))
        {
            return false;
        }
        if (!Object.Equals(this.MiddleName, student.MiddleName))
        {
            return false;
        }
        if (!Object.Equals(this.LastName, student.LastName))
        {
            return false;
        }
        if (this.SocialSecurity != student.SocialSecurity)
        {
            return false;
        }
        return true;
    }

    // Ask JUSTCODE for that miracle :)
    // Actualy I know about hashing and this is some kind of algorithm which provide minimum collisions or none ofc ;)
    public override int GetHashCode()
    {
        unchecked
        {
            int result = 17;
            result = result * 23 + ((firstName != null) ? this.firstName.GetHashCode() : 0);
            result = result * 23 + ((middleName != null) ? this.middleName.GetHashCode() : 0);
            result = result * 23 + ((lastName != null) ? this.lastName.GetHashCode() : 0);
            result = result * 23 + ((address != null) ? this.address.GetHashCode() : 0);
            result = result * 23 + ((email != null) ? this.email.GetHashCode() : 0);
            result = result * 23 + this.socialSecurity.GetHashCode();
            result = result * 23 + this.mobilePhone.GetHashCode();
            result = result * 23 + this.speciality.GetHashCode();
            result = result * 23 + this.univeristy.GetHashCode();
            result = result * 23 + this.faculty.GetHashCode();
            return result;
        }
    }

    // Pre-defining operator ==
    public static bool operator ==(Student firstStudent, Student secondStudent)
    {
        return Student.Equals(firstStudent, secondStudent); // Call the overrided Equals method
    }

    // Pre-defining operator !=
    public static bool operator !=(Student firstStudent, Student secondStudent)
    {
        return !Student.Equals(firstStudent, secondStudent);
    }

    // overriding ToString() method to print student information
    public override string ToString()
    {
        return String.Format(
            "First name: {0}\nMiddle name: {1}\nLast name: {2}\nSSN: {3}\nAddres: {4}\nMobile: {5}\ne-mail: {6}\nCours: {7}\nSpeciality: {8}\nUniversity: {9}\nFaculty: {10}",
            this.FirstName, this.MiddleName, this.LastName, this.SocialSecurity.ToString("D9"), this.Address, this.MobilePhone.ToString("D10"), this.Email, this.Course, this.Speciality, this.Univeristy, this.Faculty);
    }

    // Performing deeply clone
    public object Clone()
    {
        // Cloning the Student
        Student studentReplica = new Student(
            this.FirstName, this.MiddleName, this.LastName, this.SocialSecurity, this.Address, this.MobilePhone, this.Email, this.Course, this.Speciality, this.Univeristy, this.Faculty);

        return studentReplica; // Return the clone to user
    }

    // Overriding CompareTo to be compatible for Students
    public int CompareTo(Student student)
    { 
        if (this.FirstName != student.FirstName)
        {
            return (this.FirstName.CompareTo(student.FirstName));
        }
        if (this.MiddleName != student.MiddleName)
        {
            return (this.MiddleName.CompareTo(student.MiddleName));
        }
        if (this.LastName != student.LastName)
        {
            return (this.LastName.CompareTo(student.LastName));
        }
        if (this.SocialSecurity != student.SocialSecurity)
        {
            return (int)(this.SocialSecurity - student.SocialSecurity);
        }

        return 0; // If the two students are same one
    }
}