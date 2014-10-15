using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace TestSchool
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void StudentConstructorTestName()
        {
            string name = "Pesho Geshov";
            uint uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
            Assert.AreEqual(student.Name, "Pesho Geshov");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;
            uint uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestEmptyString()
        {
            string name = string.Empty;
            uint uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        public void UniqueNumberTestStartValue()
        {
            string name = "Pesho Geshov";
            uint uniqueNumber = 10000;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        public void UniqueNumberTestEndValue()
        {
            string name = "Pesho Geshov";
            uint uniqueNumber = 99999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestStartValueMinusOne()
        {
            string name = "Pesho Geshov";
            uint uniqueNumber = 9999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestEndValuePlusOne()
        {
            string name = "Pesho Geshov";
            uint uniqueNumber = 100000;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestEndValuePlus10000()
        {
            string name = "Pesho Geshov";
            uint uniqueNumber = 109999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestZero()
        {
            string name = "Pesho Geshov";
            uint uniqueNumber = 0;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestuintMaxValue()
        {
            string name = "Pesho Geshov";
           uint uniqueNumber = uint.MaxValue;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        public void ToStringTest()
        {
            string name = "Pesho Geshov";
            uint uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
            string expected = "Student Pesho Geshov, ID 12345; ";
            string actual;
            actual = student.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}