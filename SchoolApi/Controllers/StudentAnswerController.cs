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
    public class StudentAnswerController: BaseController<Answer>
    {
        private Context _context;
        public StudentAnswerController(Context context): base(context)
        {
            _context = context;
        }

        // Update Answer
        [HttpPut("{id}")]
        public StudentAnswer? Put(StudentAnswer studentAnswer)
        {
            var studentAnswerDbo = _context.StudentAnswers.Find(studentAnswer.Id);

            if(studentAnswerDbo == null) return null;

            _context.SaveChanges();

            return studentAnswerDbo;
        }
    }
}