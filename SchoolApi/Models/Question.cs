using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolApi.Models
{
    public class Question
    {
        public long Id {get;set;}
        public string QuestionText {get;set;}
    }
}