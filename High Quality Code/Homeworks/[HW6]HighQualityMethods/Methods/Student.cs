namespace Methods
{
    using System;

    public class Student
    {
        private string firstName, lastname, additionalInfo;
        DateTime birthDate;

        public Student(string firstName, string lastname, string birthDate, string additionalInfo)
        {
            this.FirstName = firstName;
            this.Lastname = lastname;
            this.BirthDate = DateTime.Parse(birthDate);
            this.AdditionalInfo = additionalInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter student first name!");
                }

                this.firstName = value;
            }
        }

        public string Lastname
        {
            get
            {
                return this.lastname;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter student last name!");
                }

                this.lastname = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }
            private set
            {
                if (birthDate == null)
                {
                    throw new ArgumentException("Birth date is empty!");
                }
                this.birthDate = value;
            }
        }

        public string AdditionalInfo
        {
            get
            {
                return this.additionalInfo;
            }
            set
            {
                this.additionalInfo = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            bool isOlder = this.BirthDate < other.BirthDate;

            return isOlder;
        }
    }
}