using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolApi.Models
{
    public class Answer
    {
        public long Id {get;set;}
        public string AnswerText {get;set;}
        public Boolean IsCorrect {get;set;}
    }
}