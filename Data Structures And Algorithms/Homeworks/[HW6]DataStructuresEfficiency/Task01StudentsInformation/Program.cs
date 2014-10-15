using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01StudentsInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "input.txt";
            var students = ReadTextFile(filePath);
            PrintStudents(students);
        }
        
        private static SortedDictionary<string, SortedList<string, string>> ReadTextFile(string filePath)
        {
            var students = new SortedDictionary<string, SortedList<string, string>>();

            using (var reader = new StreamReader(filePath))
            {
                var line = reader.ReadLine();
                while (!string.IsNullOrWhiteSpace(line))
                {
                    var tokens = line.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var firstName = tokens[0];
                    var lastName = tokens[1];
                    var courseName = tokens[2];

                    if (!students.ContainsKey(courseName))
                    {
                        students.Add(courseName, new SortedList<string, string>());
                    }

                    students[courseName].Add(lastName, firstName);
                    line = reader.ReadLine();
                }
            }

            return students;
        }

        private static void PrintStudents(SortedDictionary<string, SortedList<string, string>> students)
        {
            if (students.Count > 0)
            {
                StringBuilder result = new StringBuilder();
                foreach (var course in students)
                {
                    result.AppendFormat("{0}: ", course.Key);
                    foreach (var student in course.Value)
                    {
                        result.AppendFormat("{0} {1}, ", student.Value, student.Key);
                    }

                    result.Length -= 2;
                    result.AppendLine();
                }

                Console.Write(result.ToString());
            }
        }
    }
}