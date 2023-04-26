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
    public class CourseController: BaseController<Answer>
    {
        private Context _context;
        public CourseController(Context context): base(context)
        {
            _context = context;
        }

        // Update Answer
        [HttpPut]
        public Course? Put(Course course)
        {
            var courseDbo = _context.Courses.Find(course.Id);

            if(courseDbo == null) return null;

            courseDbo.Name = course.Name;
            _context.SaveChanges();

            return courseDbo;
        }
    }
}