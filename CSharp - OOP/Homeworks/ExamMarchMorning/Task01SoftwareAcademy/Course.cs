using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    class Course : ICourse
    {
        private string name;
        List<string> topics;

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
                    throw new ArgumentException("Name");
                }
                this.name = value;
            }
        }

        public ITeacher Teacher { get; set; }

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            topics = new List<string>();
        }

        public void AddTopic(string topic)
        {
            topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0}: ", this.GetType().Name);
            result.AppendFormat("Name={0};", this.Name);
            
            if (this.Teacher != null)
            {
                result.AppendFormat(" Teacher={0};", this.Teacher.Name);
            }
            
            if (topics.Count > 0)
            {
                result.Append(" Topics=[");
                for (int i = 0; i < topics.Count; i++)
                {
                    if (i != (topics.Count - 1))
                    {
                        result.AppendFormat("{0}, ", topics[i]);
                    }
                    else
                    {
                        result.AppendFormat("{0}]", topics[i]);
                    }
                }
            }

            return result.ToString();
        }
    }
}