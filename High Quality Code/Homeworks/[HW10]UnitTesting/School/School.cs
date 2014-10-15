namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {
        public School(List<Course> courses = null)
        {
            this.Courses = new List<Course>();
        }

        public List<Course> Courses { get; set; }

        public void AddCourse(Course course)
        {
            this.Courses.Add(course);
        }
        
        public void RemoveCourse(Course course)
        {
            bool courseFound = false;
            for (int i = 0; i < this.Courses.Count; i++)
            {
                if (this.Courses[i].Name == course.Name)
                {
                    courseFound = true;
                    this.Courses.Remove(course);
                    break; // if course is removed
                }
            }

            if (!courseFound)
            {
                throw new ArgumentException("This course doesn't exist");
            }
        }
    }
}