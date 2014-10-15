namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Course
    {
        public const byte MaxStudentsInCourse = 29;

        private string name;

        public Course(string name, IList<Student> students = null)
        {
            this.Students = new List<Student>();
            this.Name = name;
        }

        public List<Student> Students { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Course name is empty!");
                }
        
                this.name = value;
            }
        }

        public void AddStudent(Student student)
        {
            bool studentFound = this.CheckIfStudentIsFound(student);

            if (studentFound)
            {
                throw new ArgumentException("The student has been added already!");
            }

            if (this.Students.Count + 1<= MaxStudentsInCourse)
            {
                this.Students.Add(student);
            }
            else
            {
                throw new ArgumentOutOfRangeException("The course is full. No more students can be added!");
            }
        }

        public void RemoveStudent(Student student)
        {
            bool studentFound = this.CheckIfStudentIsFound(student);

            if (!studentFound)
            {
                throw new ArgumentException("The student does not exist in this course!");
            }

            this.Students.Remove(student);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Course name {0}; ", this.Name));

            if (this.Students.Count != 0)
            {
                for (int i = 0; i < this.Students.Count; i++)
                {
                    sb.Append(this.Students[i]);
                }
            }

            return sb.ToString();
        }

        private bool CheckIfStudentIsFound(Student student)
        {
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].UniqueNumber == student.UniqueNumber)
                {
                    return true;
                }
            }

            return false;
        }
    }
}