using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace StudentSystem.Web.Models
{
    public class CourseViewModel
    {
        public static Expression<Func<Course, CourseViewModel>> FormCourse
        {
            get
            {
                return c => new CourseViewModel
                {
                    Name = c.Name,
                    Description = c.Description
                };
            }
        }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}