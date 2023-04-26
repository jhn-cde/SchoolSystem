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
    public class StudentController: BaseController<Answer>
    {
        private Context _context;
        public StudentController(Context context): base(context)
        {
            _context = context;
        }

        // Update Answer
        [HttpPut]
        public Student? Put(Student student)
        {
            var studentDbo = _context.Students.Find(student.Id);

            if(studentDbo == null) return null;

            studentDbo.FirstName = student.FirstName;
            studentDbo.LastName = student.LastName;
            _context.SaveChanges();

            return studentDbo;
        }
    }
}