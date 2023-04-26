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
    public class ExamController: BaseController<Answer>
    {
        private Context _context;
        public ExamController(Context context): base(context)
        {
            _context = context;
        }

        // Update Answer
        [HttpPut]
        public Exam? Put(Exam exam)
        {
            var examDbo = _context.Exams.Find(exam.Id);

            if(examDbo == null) return null;

            examDbo.Name = exam.Name;
            examDbo.Date = exam.Date;
            _context.SaveChanges();

            return examDbo;
        }
    }
}