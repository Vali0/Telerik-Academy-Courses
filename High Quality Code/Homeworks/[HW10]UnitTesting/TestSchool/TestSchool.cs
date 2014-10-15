namespace TestSchool
{
    using System;
    using School;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class TestSchool
    {
        [TestMethod]
        public void SchoolConstructorTest()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Assert.IsNotNull(school);
        }

        [TestMethod]
        public void AddCourseTest()
        {
            List<Course> courses = new List<Course>();
            Course javascript = new Course("Javascript");
            School school = new School(courses);
            school.AddCourse(javascript);
            Assert.AreEqual(javascript.Name, school.Courses[0].Name);
        }

        [TestMethod]
        public void RemoveCourseTest()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Course javascript = new Course("Javascript");
            school.AddCourse(javascript);
            school.RemoveCourse(javascript);
            Assert.IsTrue(school.Courses.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingCourseTest()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Course javascript = new Course("Javascript");
            school.RemoveCourse(javascript);
        }
    }
}