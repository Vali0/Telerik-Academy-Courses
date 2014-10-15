using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentSystem.Data;
using StudentSystem.Data.Repositories;
using StudentSystem.Models;
using StudentSystem.Web.Models;

namespace StudentSystem.Web.Controllers
{
    public class StudentsController : ApiController
    {
        private IStudentSystemData data;

        public StudentsController() : this(new StudentsSystemData())
        {
        }

        public StudentsController(IStudentSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var students = this.data.Students.All().Select(StudentViewModel.FromStudent);

            return Ok(students);
        }

        [HttpPost]
        public IHttpActionResult Post(StudentViewModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newStudent = new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Level = student.Level
            };

            this.data.Students.Add(newStudent);
            this.data.SaveChanges();

            return Ok(newStudent);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, StudentViewModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingStudent = this.data.Students.All().FirstOrDefault(x => x.StudentIdentification == id);
            if (existingStudent == null)
            {
                return BadRequest("No such student!");
            }

            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.Level = student.Level;
            this.data.SaveChanges();

            return Ok(existingStudent);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var existingStudent = this.data.Students.All().FirstOrDefault(x => x.StudentIdentification == id);

            if (existingStudent == null)
            {
                return BadRequest("No such student!");
            }

            this.data.Students.Delete(existingStudent);
            this.data.SaveChanges();

            return Ok();
        }
    }
}