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
    public class StudentCourseController: BaseController<Answer>
    {
        private Context _context;
        public StudentCourseController(Context context): base(context)
        {
            _context = context;
        }

        // Update Answer
        [HttpPut("{id}")]
        public StudentCourse? Put(StudentCourse studentCourse)
        {
            var studentCourseDbo = _context.StudentCourses.Find(studentCourse.Id);

            if(studentCourseDbo == null) return null;

            _context.SaveChanges();

            return studentCourseDbo;
        }
    }
}