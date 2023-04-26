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
    public class AnswerController: BaseController<Answer>
    {
        private Context _context;
        public AnswerController(Context context): base(context)
        {
            _context = context;
        }

        // Update Answer
        [HttpPut]
        public Answer? Put(Answer answer)
        {
            var answerDbo = _context.Answers.Find(answer.Id);

            if(answerDbo == null) return null;

            answerDbo.AnswerText = answer.AnswerText;
            answerDbo.IsCorrect = answer.IsCorrect;
            _context.SaveChanges();

            return answerDbo;
        }
    }
}