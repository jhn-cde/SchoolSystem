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
    public class TeacherController: BaseController<Answer>
    {
        private Context _context;
        public TeacherController(Context context): base(context)
        {
            _context = context;
        }

        // Update Answer
        [HttpPut("{id}")]
        public Teacher? Put(Teacher teacher)
        {
            var teacherDbo = _context.Teachers.Find(teacher.Id);

            if(teacherDbo == null) return null;

            teacherDbo.FirstName = teacher.FirstName;
            teacherDbo.LastName = teacher.LastName;
            _context.SaveChanges();

            return teacherDbo;
        }
    }
}