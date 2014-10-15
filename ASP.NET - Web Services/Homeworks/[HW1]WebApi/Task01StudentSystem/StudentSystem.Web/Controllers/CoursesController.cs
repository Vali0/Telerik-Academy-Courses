using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentSystem.Data;
using StudentSystem.Web.Models;
using StudentSystem.Models;

namespace StudentSystem.Web.Controllers
{
    public class CoursesController : ApiController
    {
         private IStudentSystemData data;

        public CoursesController() : this(new StudentsSystemData())
        {
        }

        public CoursesController(IStudentSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var courses = this.data.Courses.All().Select(CourseViewModel.FormCourse);

            return Ok(courses);
        }

        [HttpPost]
        public IHttpActionResult Post(CourseViewModel course)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newCourse = new Course
            {
                Name = course.Name,
                Description = course.Description
            };

            this.data.Courses.Add(newCourse);
            this.data.SaveChanges();

            return Ok(newCourse);
        }

        [HttpPut]
        public IHttpActionResult Put(Guid id, CourseViewModel course)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingCourse = this.data.Courses.All().FirstOrDefault(x => x.Id == id);
            if (existingCourse == null)
            {
                return BadRequest("No such course!");
            }

            existingCourse.Name = course.Name;
            existingCourse.Description = course.Description;
            this.data.SaveChanges();

            return Ok(existingCourse);
        }

        [HttpDelete]
        public IHttpActionResult Delete(Guid id)
        {
            var existingCourse = this.data.Courses.All().FirstOrDefault(x => x.Id == id);

            if (existingCourse == null)
            {
                return BadRequest("No such Course!");
            }
            
            this.data.Courses.Delete(existingCourse);
            this.data.SaveChanges();

            return Ok();
        }
    }
}
