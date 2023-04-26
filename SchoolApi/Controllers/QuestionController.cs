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
    public class QuestionController: BaseController<Answer>
    {
        private Context _context;
        public QuestionController(Context context): base(context)
        {
            _context = context;
        }

        // Update Answer
        [HttpPut("{id}")]
        public Question? Put(Question question)
        {
            var questionDbo = _context.Questions.Find(question.Id);

            if(questionDbo == null) return null;

            questionDbo.QuestionText = question.QuestionText;
            _context.SaveChanges();

            return questionDbo;
        }
    }
}