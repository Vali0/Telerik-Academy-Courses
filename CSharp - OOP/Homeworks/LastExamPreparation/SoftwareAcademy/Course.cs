using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    abstract class Course : ICourse
    {
        private string name;
        private ITeacher teacher;
        private List<string> topicList;

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
                    throw new ArgumentNullException("Course name");
                }
                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            topicList = new List<string>();
        }

        public void AddTopic(string topic)
        {
            topicList.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0}:", this.GetType().Name);
            result.AppendFormat(" Name={0}", this.Name);
            if (this.Teacher != null)
            {
                result.AppendFormat("; Teacher={0}", this.Teacher);
            }
            if (topicList.Count > 0)
            {
                result.Append("; Topics=[");
                foreach (var item in topicList)
                {
                    result.AppendFormat("{0}, ", item);
                }
                result.Length -= 2;
                result.Append("]");
            }

            return result.ToString();
        }
    }
}