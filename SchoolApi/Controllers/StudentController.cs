using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;

namespace SchoolApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController: ControllerBase
    {
        private Context _context;
        public StudentController(Context context)
        {
            _context = context;
        }

        // Get Students
        [HttpGet]
        public IEnumerable<Student> GetStudents(){
            return _context.Students.ToList();
        }

        // Get one student
        [HttpGet("{id}")]
        public Student? GetStudent(long id){
            var student = _context.Students.Find(id);
            return student;
        }

        // Insert Student
        [HttpPost]
        public Student InsertStudent(Student student){
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        // Update student
        [HttpPut]
        public Student? UpdateStudent(Student student){
            var studentDbo = _context.Students.Find(student.Id);

            if(studentDbo == null) return null;

            studentDbo.FirstName = student.FirstName;
            studentDbo.LastName = student.LastName;
            _context.SaveChanges();

            return studentDbo;
        }

        // Delete student
        [HttpDelete("{id}")]
        public bool DeleteStudent(long id){
            var studentDbo = _context.Students.Find(id);
            if(studentDbo == null) return false;

            _context.Students.Remove(studentDbo);
            _context.SaveChanges();
            return true;
        }

    }
}