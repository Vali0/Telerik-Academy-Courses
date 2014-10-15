namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using School;

    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        public void CourseConstructorTestName()
        {
            string name = "Javascript";
            Course course = new Course(name);
            Assert.AreEqual(course.Name, "Javascript");
        }

        [TestMethod]
        public void CourseConstructorTestListStudents()
        {
            string name = "Javascript";
            Student maria = new Student("Pesho Geshov", 12345);
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            course.AddStudent(maria);
            Assert.IsTrue(course.Students.Contains(maria));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestEmptyString()
        {
            string name = string.Empty;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        public void AddStudentTestOneStudent()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Pesho Geshov", 12345);
            course.AddStudent(maria);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        public void AddStudentTestTwoStudents()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Pesho Geshov", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            course.AddStudent(maria);
            course.AddStudent(petar);
            Assert.IsTrue(course.Students.Count == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentTestSameStudentTwoTimes()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Pesho Geshov", 12345);
            course.AddStudent(maria);
            course.AddStudent(maria);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudentTestMoreThanMaximumStudents()
        {
            string courseName = "css";
            List<Student> students = new List<Student>();
            Course cssCourse = new Course(courseName, students);

            for (uint courseNumber = 10001; courseNumber < 10032; courseNumber++)
            {
                cssCourse.AddStudent(new Student("Pesho", courseNumber));
            }
        }

        [TestMethod]
        public void RemoveStudentTest()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Pesho Geshov", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            course.AddStudent(maria);
            course.AddStudent(petar);
            course.RemoveStudent(petar);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingStudentTest()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Pesho Geshov", 12345);
            course.RemoveStudent(maria);
        }

        [TestMethod]
        public void ToStringTestOneStudent()
        {
            string name = "Javascript";
            Student maria = new Student("Pesho Geshov", 12345);
            IList<Student> students = new List<Student>();
            Course javascript = new Course(name, students);
            javascript.AddStudent(maria);
            string expected = "Course name Javascript; Student Pesho Geshov, ID 12345; ";
            string actual;
            actual = javascript.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringTestTwoStudents()
        {
            string name = "Javascript";
            Student maria = new Student("Pesho Geshov", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            IList<Student> students = new List<Student>();
            Course javascript = new Course(name, students);
            javascript.AddStudent(maria);
            javascript.AddStudent(petar);
            string expected = "Course name Javascript; Student Pesho Geshov, ID 12345; Student Petar Marinov, ID 23445; ";
            string actual;
            actual = javascript.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}