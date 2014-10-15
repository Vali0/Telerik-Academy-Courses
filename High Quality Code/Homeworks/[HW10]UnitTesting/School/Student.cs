namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string name;
        private uint uniqueNumber;

        public Student(string name, uint uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

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
                    throw new ArgumentNullException("Name cannot be missing!");
                }
                
                this.name = value;
            }
        }

        public uint UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The unique number of student {0} must be between 10000 and 99999!", this.Name));
                }
                    
                this.uniqueNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student {0}, ID {1}; ", this.Name, this.UniqueNumber);
        }
    }
}