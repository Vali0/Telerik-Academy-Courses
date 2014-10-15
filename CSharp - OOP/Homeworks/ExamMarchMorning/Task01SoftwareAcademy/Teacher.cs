using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    class Teacher : ITeacher
    {
        private string name;
        IList<ICourse> courses;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("teacher name?");
                }
                this.name = value;
            }
        }

        public Teacher(string name)
        {
            this.Name = name;
            courses = new List<ICourse>();
        }

        public void AddCourse(ICourse course)
        {
            courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Teacher: ");
            result.AppendFormat("Name={0}", this.Name);
            if (courses.Count > 0)
            {
                result.Append("; Courses=[");
                for (int i = 0; i < courses.Count; i++)
                {
                    if (i != (courses.Count - 1))
                    {
                        result.AppendFormat("{0}, ", courses[i].Name);
                    }
                    else
                    {
                        result.AppendFormat("{0}];", courses[i].Name);
                    }
                }
            }

            return result.ToString();
        }
    }
}