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
        private IList<ICourse> courseList;

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
                    throw new ArgumentNullException("Teacher name");
                }
                this.name = value;
            }
        }

        public Teacher(string name)
        {
            this.Name = name;
            courseList = new List<ICourse>();
        }

        public void AddCourse(ICourse course)
        {
            courseList.Add(course);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Teacher: ");
            result.AppendFormat("Name={0}", this.Name);
            if (courseList.Count > 0)
            {
                result.Append("; Courses=[");
                foreach (var item in courseList)
                {
                    result.AppendFormat("{0}, ", item.Name);
                }

                result.Length -= 2;
                result.Append("]");
            }
            return result.ToString();
        }
    }
}