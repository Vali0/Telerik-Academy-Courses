using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace StudentSystem.Web.Models
{
    public class StudentViewModel
    {
        public static Expression<Func<Student, StudentViewModel>> FromStudent
        {
            get
            {
                return a => new StudentViewModel
                {
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Level = a.Level
                };
            }
        }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Level { get; set; }
    }
}